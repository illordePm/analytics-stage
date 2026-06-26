using analytics_backend.Data;
using analytics_backend.DTOs;
using analytics_backend.Helper;
using analytics_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace analytics_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesDataGraphController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public SalesDataGraphController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet(Name = "GetSalesDataGraph")]
                                                
                                                                        //di default fissato a mese precedente                                                                        //la cerca come comparisonMode, cioè il nome esterno (di angular)
        public ActionResult<DashboardResponse> Get([FromQuery] int month, [FromQuery] int year, [FromQuery] int? shopId, [FromQuery] Comparison comparisonMode = Comparison.PreviousMonth)
        {

            (int AnnoPrecedente, int MesePrecedente, int AnnoCorrente, int MeseCorrente) = Filter.ComparisonFilterHelper(comparisonMode, month, year);

            var DashboardResponse = new DashboardResponse
            {
                SalesGraph = SalesDataGraph(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId),
                TotalReceipts = TotalReceipts(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId),
                AverageReceipts = AverageReceipt(MeseCorrente, AnnoCorrente, MesePrecedente, AnnoPrecedente, shopId)
            };

            return Ok(DashboardResponse);

            
        }
        private SalesDataGraphResponse SalesDataGraph(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
        {
            int[] giorni = [7, 13, 19, 25, 31];

            DateTime[] dates = new DateTime[giorni.Length];
            SalesDataCurrPrev[] current = new SalesDataCurrPrev[giorni.Length];
            SalesDataCurrPrev[] previous = new SalesDataCurrPrev[giorni.Length];

            int ultimiGiorniMeseCorrente = DateTime.DaysInMonth(AnnoCorrente, MeseCorrente);
            int ultimiGiorniMesePrecedente = DateTime.DaysInMonth(AnnoPrecedente, MesePrecedente);

            for (int i = 0; i < giorni.Length; i++)
            {
                int from = i == 0 ? 1 : giorni[i - 1];
                int to = giorni[i];
                int giorno = giorni[i];

                dates[i] = new DateTime(AnnoCorrente, MeseCorrente, Math.Min(giorno, ultimiGiorniMeseCorrente));

                int fineEffettivaCorrente = (i == giorni.Length - 1) ? ultimiGiorniMeseCorrente : to;
                int fineEffettivaPrecedente = (i == giorni.Length - 1) ? ultimiGiorniMesePrecedente : to;

                DateTime[] CurrentTimes = GenerateDateRange(MeseCorrente, AnnoCorrente, from, fineEffettivaCorrente);
                DateTime[] PreviousTimes = GenerateDateRange(MesePrecedente, AnnoPrecedente, from, fineEffettivaPrecedente);

                var sumCurrent = GetSaleReportsInRange(MeseCorrente, AnnoCorrente, from, fineEffettivaCorrente);
                var sumPrevious = GetSaleReportsInRange(MesePrecedente, AnnoPrecedente, from, fineEffettivaPrecedente);


                if (negozioId != null)
                {
                    sumCurrent = sumCurrent.Where(wt => wt.ShopId == negozioId);
                    sumPrevious = sumPrevious.Where(wt => wt.ShopId == negozioId);
                }

                decimal SumCurrent = sumCurrent.Sum(sr => sr.RowTotalPrice ?? 0);
                decimal SumPrevious = sumPrevious.Sum(sr => sr.RowTotalPrice ?? 0);

                current[i] = new SalesDataCurrPrev
                {
                    RangeOfTime = CurrentTimes,
                    RangeOfSales = SumCurrent
                };

                previous[i] = new SalesDataCurrPrev
                {
                    RangeOfTime = PreviousTimes,
                    RangeOfSales = SumPrevious
                };
            }

            return new SalesDataGraphResponse
            {
                Dates = dates,
                Current = current,
                Previous = previous
            };
        }

        private DateTime[] GenerateDateRange(int month, int year, int from, int to)
        {
            int count = Math.Max(0, to - from + 1);
            DateTime[] times = new DateTime[count];
            for (int i = 0; i < count; i++)
            {
                times[i] = new DateTime(year, month, from + i);
            }
            return times;
        }

        private IQueryable<SsvSaleReportsRound> GetSaleReportsInRange(int month, int year, int from, int to)
        {
            return _appDbContext.SsvSaleReportsRounds.Where(sr =>
                sr.TransactionDate.HasValue &&
                sr.TransactionDate.Value.Month == month &&
                sr.TransactionDate.Value.Year == year &&
                sr.TransactionDate.Value.Day >= from &&
                sr.TransactionDate.Value.Day <= to
            );
        }










        private Report<int> TotalReceipts(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
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
                    currentDictionary[data].Add(heading ??0);
            }
    
            //conteggio del giorno= numero di elementi dentro l'HashSet di quella data
            var DailyCurrentPeriodDataCount = currentDictionary
                .Select(g => new DailyCountDetail
                {
                    Day = g.Key,
                    Count = g.Value.Count //numero di heading unici (grazie ad hashset) per questo giorno
                })
                .OrderBy(g => g.Day)
                .ToArray();

            //totale dei totali giornalierei
            int SumCurrent = DailyCurrentPeriodDataCount.Sum(g => g.Count);

            //stessa logica per giorno precedente
            var previousDictionary = new Dictionary<DateTime, HashSet<int>>();
            foreach (var t in previousDataList)
            {
                var data = t.TransactionDate.Value.Date;
                if (!previousDictionary.ContainsKey(data)) 
                    previousDictionary[data] = new HashSet<int>();

                previousDictionary[data].Add(t.HeadingId?? 0);
            }
            int SumPrevious = previousDictionary.Sum(g => g.Value.Count);

            return new Report<int>
            {
                Current = SumCurrent,
                Previous = SumPrevious,
                DailyData = DailyCurrentPeriodDataCount
            };
        }


        private Report<decimal> AverageReceipt(int MeseCorrente, int AnnoCorrente, int MesePrecedente, int AnnoPrecedente, int? negozioId)
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

            //array x istogramma
            var DailyCurrentPeriodDataAverage = currentDictionary
                .Select(g => new DailyAverageDetail
                {
                    Day = g.Key,
                    //g.value è il dizionario interno
                    //g.value.count conta quante chiavi->headingid ci sono dentro
                    //.Values contiene i fatturati dei singoli negozi di quel giorno
                    Average = g.Value.Count > 0 ? g.Value.Values.Average() : 0
                })
                .OrderBy(g => g.Day)
                .ToArray();

            //media totale attuale
            //selectMany prende tutti i dizionari interni e li unisce in un'unica collezione ->poi vengono sommati
            decimal totalCurrent = currentDictionary.SelectMany(g => g.Value.Values).Sum(); //somma tutti i fatturati
            int totalUniqueStoresCurrent = currentDictionary.Sum(g => g.Value.Count);   //negozi unici in quel dato giorno e li somma tutti
            decimal DailyCurrentPeriodDataAvg = totalUniqueStoresCurrent > 0 ? (totalCurrent / totalUniqueStoresCurrent) : 0; //fa media

            //idem x mese precedente
            decimal totalPrevious = previousDictionary.SelectMany(g => g.Value.Values).Sum();
            int totalUniqueStoresPrevious = previousDictionary.Sum(g => g.Value.Count);
            decimal DailyPreviousPeriodDataAvg = totalUniqueStoresPrevious > 0 ? (totalPrevious / totalUniqueStoresPrevious) : 0;

            return new Report<decimal>
            {
                Current = DailyCurrentPeriodDataAvg,
                Previous = DailyPreviousPeriodDataAvg,
                DailyAverageData = DailyCurrentPeriodDataAverage
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

            if (negozioId.HasValue)
            {
                currentPeriodData = currentPeriodData.Where(sr => sr.ShopId == negozioId);
                previousPeriodData = previousPeriodData.Where(sr => sr.ShopId == negozioId);
            }

            return (currentPeriodData, previousPeriodData);
        }
    }
}