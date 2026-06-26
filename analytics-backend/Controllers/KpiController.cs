using analytics_backend.Data;
using analytics_backend.DTOs;
using analytics_backend.Helper;
using analytics_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Linq;

namespace analytics_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KpiController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public KpiController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // richiesta HTTP GET = metodo usato dal client per richiedere e ottenere dati da un server
        [HttpGet(Name = "GetKPI")]
        public ActionResult<KpiContainer> Get([FromQuery] int month, [FromQuery] int year, [FromQuery] int? shopId, [FromQuery] Comparison comparisonMode = Comparison.PreviousMonth)
        {

            (int AnnoPrecedente, int MesePrecedente, int AnnoCorrente, int MeseCorrente) = Filter.ComparisonFilterHelper(comparisonMode, month, year);

            KpiContainer containerResponse = new KpiContainer
            {
                TotalBought = TotalBoughtKpi(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId),
                TotalSales = TotalSalesKpi(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId),
                TotalReceipts = TotalReceiptsKpi(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId),
                AverageReceipt = AverageReceiptKpi(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId)
            };

            return Ok(containerResponse);
        }

        private KpiValueResponse TotalBoughtKpi(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
        {

            var templateValidi = new List<int> { 1, 2, 3 }; //relativi agli acquisti

            var prevQuery = _appDbContext.WarehouseTransactions
               .Include(wt => wt.DocumentHeading) //proprietà di navigazione
               .Where(wt => wt.DocumentHeading.Date.Month == (MesePrecedente) &&
               templateValidi.Contains(wt.Causal.Template) &&
               wt.DocumentHeading.Date.Year == AnnoPrecedente);

            var currQuery = _appDbContext.WarehouseTransactions
                .Include(wt => wt.DocumentHeading) //.ThenInclude
                .Where(wt => wt.DocumentHeading.Date.Month == MeseCorrente &&
                templateValidi.Contains(wt.Causal.Template) &&
                wt.DocumentHeading.Date.Year == AnnoCorrente);

            if (negozioId != null)
            {
                prevQuery = prevQuery.Where(wt => wt.ShopId == negozioId);
                currQuery = currQuery.Where(wt => wt.ShopId == negozioId);
            }

            decimal SumCurrent = currQuery.Sum(wt => wt.RowTotalCost);
            decimal SumPrevious = prevQuery.Sum(wt => wt.RowTotalCost);

            return new KpiValueResponse
            {
                CurrentValue = SumCurrent,
                PreviousValue = SumPrevious
            };
        }

        private KpiValueResponse TotalSalesKpi(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
        {

            var (currentPeriodData, previousPeriodData) = QueryModel(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, negozioId);

            decimal SumCurrent = currentPeriodData.Sum(sr => sr.RowTotalPrice ?? 0);
            decimal SumPrevious = previousPeriodData.Sum(sr => sr.RowTotalPrice ?? 0);


            return new KpiValueResponse
            {
                CurrentValue = SumCurrent,
                PreviousValue = SumPrevious
            };
        }

        private KpiValueResponse TotalReceiptsKpi(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
        {

            var (currentPeriodData, previousPeriodData) = QueryModel(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, negozioId);

            var currentDataList = currentPeriodData.ToList();
            var previousDataList = previousPeriodData.ToList();

            //data -> insieme di HeadingId unici->hashset garantisce solo elementi unici
            var currentDictionary = new Dictionary<DateTime, HashSet<int>>();

            foreach (var t in currentDataList)
            {
                var data = t.TransactionDate.Value.Date;
                int? heading = t.HeadingId;

                //se la data non esiste ancora, la inizializzo con un insieme vuoto
                if (!currentDictionary.ContainsKey(data))
                    currentDictionary[data] = new HashSet<int>();

                //inserisco heading-> se c'era già hashset lo ignora automaticamente
                currentDictionary[data].Add(heading ?? 0);
            }

            var previousDictionary = new Dictionary<DateTime, HashSet<int>>();
            //stessa logica per giorno precedente
            foreach (var t in previousDataList)
            {
                var data = t.TransactionDate.Value.Date;
                if (!previousDictionary.ContainsKey(data))
                    previousDictionary[data] = new HashSet<int>();

                previousDictionary[data].Add(t.HeadingId ?? 0);
            }

            int SumCurrent = currentDictionary.Sum(g => g.Value.Count);
            int SumPrevious = previousDictionary.Sum(g => g.Value.Count);

            return new KpiValueResponse
            {
                CurrentValue = SumCurrent,
                PreviousValue = SumPrevious
            };
        }

        private KpiValueResponse AverageReceiptKpi(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
        {

            var (currentPeriodData, previousPeriodData) = QueryModel(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, negozioId);

            var currentDataList = currentPeriodData.ToList();
            var previousDataList = previousPeriodData.ToList();

            //stessa logica di prima ma senza hashset, gestito manualmente il controllo degli headingId
            //la chiave univoca del diz interno è headingid e il valore è il fatturato per quel heading
            //è come un hashset in quanto le chiavi (int) non possono essere duplicate
            var currentDictionary = new Dictionary<DateTime, Dictionary<int, decimal>>();

            foreach (var t in currentDataList)
            {
                var data = t.TransactionDate.Value.Date;
                int heading = t.HeadingId ?? 0;
                decimal valore = t.RowTotalPrice ?? 0;

                //se data non inclusa la includo
                if (!currentDictionary.ContainsKey(data))
                    currentDictionary[data] = new Dictionary<int, decimal>();

                //se headingid non è ancora incluso lo aggiungo assegnandogli il valore
                if (!currentDictionary[data].ContainsKey(heading))
                {
                    currentDictionary[data][heading] = valore;
                }
                else   //altrimenti accumulo il valore al totale già presente per quell'headingid
                {
                    currentDictionary[data][heading] += valore; //aumenta il valore senza contarlo nuovamente
                }
            }

            //idem per mese precedente

            var previousDictionary = new Dictionary<DateTime, Dictionary<int, decimal>>();
            foreach (var t in previousDataList)
            {
                var data = t.TransactionDate.Value.Date;
                int heading = t.HeadingId ?? 0;
                decimal valore = t.RowTotalPrice ?? 0;

                if (!previousDictionary.ContainsKey(data))
                    previousDictionary[data] = new Dictionary<int, decimal>();

                if (!previousDictionary[data].ContainsKey(heading))
                    previousDictionary[data][heading] = valore;
                else
                    previousDictionary[data][heading] += valore;
            }

            //media totale attuale
            //selectMany prende tutti i dizionari interni e li unisce in un'unica collezione ->poi vengono sommati
            decimal totalCurrent = currentDictionary.SelectMany(g => g.Value.Values).Sum(); //somma tutti i fatturati
            int totalUniqueStoresCurrent = currentDictionary.Sum(g => g.Value.Count);   //negozi unici in quel dato giorno e li somma tutti
            decimal DailyCurrentPeriodDataAvg = totalUniqueStoresCurrent > 0 ? (totalCurrent / totalUniqueStoresCurrent) : 0; //fa media

            //idem x mese precedente
            decimal totalPrevious = previousDictionary.SelectMany(g => g.Value.Values).Sum();
            int totalUniqueStoresPrevious = previousDictionary.Sum(g => g.Value.Count);
            decimal DailyPreviousPeriodDataAvg = totalUniqueStoresPrevious > 0 ? (totalPrevious / totalUniqueStoresPrevious) : 0;

            return new KpiValueResponse
            {
                CurrentValue = DailyCurrentPeriodDataAvg,
                PreviousValue = DailyPreviousPeriodDataAvg,
            };
        }

        private (IQueryable<SsvSaleReportsRound> currentPeriodData, IQueryable<SsvSaleReportsRound> previousPeriodData) QueryModel(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
        {
            var currentPeriodData = _appDbContext.SsvSaleReportsRounds.
                Where(sr =>
                 sr.TransactionDate.HasValue &&  //controlla i campi nullable
                 sr.TransactionDate.Value.Month == MeseCorrente &&
                 sr.TransactionDate.Value.Year == AnnoCorrente
                 );

            var previousPeriodData = _appDbContext.SsvSaleReportsRounds.
                Where(sr =>
                    sr.TransactionDate.HasValue &&  //controlla i campi nullable
                    sr.TransactionDate.Value.Month == MesePrecedente &&
                    sr.TransactionDate.Value.Year == AnnoPrecedente
                    );

            if (negozioId != null && negozioId.HasValue)
            {
                currentPeriodData = currentPeriodData.Where(sr => sr.ShopId == negozioId);
                previousPeriodData = previousPeriodData.Where(sr => sr.ShopId == negozioId);
            }

            return (currentPeriodData, previousPeriodData);
        }
    }
}