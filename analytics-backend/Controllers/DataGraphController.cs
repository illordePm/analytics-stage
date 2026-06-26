using analytics_backend.Data;
using analytics_backend.DTOs;
using analytics_backend.Helper;
using analytics_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace analytics_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataGraphController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public DataGraphController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet(Name = "GetDataGraph")]
        public ActionResult<DataGraphResponse> Get([FromQuery] int? shopId, [FromQuery] int nMonth, [FromQuery] int nYear, [FromQuery] Comparison comparisonMode= Comparison.PreviousMonth)
        {
            var templateValidi = new List<int> { 1, 2, 3 }; // template degli acquisti
            int ultimoDelMese = DateTime.DaysInMonth(nYear, nMonth);
            int[] giorni = [7, 13, 19, 25, ultimoDelMese];
            DateTime[] dates = new DateTime[giorni.Length];

            for (int i = 0; i < giorni.Length; i++)
            {
                dates[i] = new DateTime(nYear, nMonth, Math.Min(giorni[i], ultimoDelMese));
            }

            (int AnnoPrecedente, int MesePrecedente, int AnnoCorrente, int MeseCorrente) = Filter.ComparisonFilterHelper(comparisonMode, nMonth, nYear);
            

            DataGraphResponse response = new DataGraphResponse
            {
                Dates = dates,
                Current = GetDataCurrPrev(templateValidi, shopId, AnnoCorrente, MeseCorrente, giorni),
                Previous = GetDataCurrPrev(templateValidi, shopId, AnnoPrecedente, MesePrecedente, giorni),
                Suppliers = GetSuppliersPurchases(templateValidi, shopId, nYear, nMonth)
            };

            return Ok(response);
        }


        private DataCurrPrev[] GetDataCurrPrev(List<int> templateValidi, int? shopId, int anno, int mese, int[] giorni)
        {
            int ultimiGiorniMese = DateTime.DaysInMonth(anno, mese);
            DataCurrPrev[] result = new DataCurrPrev[giorni.Length];

            for (int i = 0; i < giorni.Length; i++)
            {
                int from = i == 0 ? 1 : giorni[i - 1];
                int to = giorni[i];

                int fineEffettiva = (i == giorni.Length - 1) ? ultimiGiorniMese : to - 1;

                // RangeOfTime
                int n1 = Math.Max(0, fineEffettiva - from + 1);
                DateTime[] currentTimes = new DateTime[n1];
                for (int subIdx = 0; subIdx < n1; subIdx++)
                {
                    currentTimes[subIdx] = new DateTime(anno, mese, from + subIdx);
                }

                // query per sommare gli acquisti
                var sumCurrent = _appDbContext.WarehouseTransactions
                    .Where(wt =>
                        wt.DocumentHeading.Date.Month == mese &&
                        wt.DocumentHeading.Date.Year == anno &&
                        wt.DocumentHeading.Date.Day >= from &&
                        wt.DocumentHeading.Date.Day <= fineEffettiva &&
                        templateValidi.Contains(wt.Causal.Template));

                if (shopId != null)
                {
                    sumCurrent = sumCurrent.Where(wt => wt.ShopId == shopId);
                }

                decimal n = sumCurrent.Sum(wt => wt.RowTotalCost);

                result[i] = new DataCurrPrev
                {
                    RangeOfTime = currentTimes,
                    RangeOfPurchase = n
                };
            }

            return result;
        }

        private SuppliersPurchases[] GetSuppliersPurchases(List<int> templateValidi, int? shopId, int nYear, int nMonth)
        {
            // per i suppliers
            var suppliersQuery = _appDbContext.WarehouseTransactions
                .Where(wt =>
                    wt.DocumentHeading.Date.Month == nMonth &&
                    wt.DocumentHeading.Date.Year == nYear &&
                    templateValidi.Contains(wt.Causal.Template));

            if (shopId != null)
            {
                suppliersQuery = suppliersQuery.Where(wt => wt.ShopId == shopId);
            }

            var suppliersData = suppliersQuery
                .GroupBy(wt => wt.DocumentHeading.Supplier.Name)
                .Select(g => new SuppliersPurchases
                {
                    Name = g.Key ?? "Fornitore Sconosciuto",
                    Total = g.Sum(wt => wt.RowTotalCost)
                })
                .OrderByDescending(sup => sup.Total)
                .ToArray();

            SuppliersPurchases[] top5, totalSuppliers;
            decimal others;

            if (suppliersData.Length > 5)
            {
                top5 = suppliersData.Take(5).ToArray();
                others = suppliersData.Skip(5).Sum(sum => sum.Total);

                totalSuppliers = new SuppliersPurchases[6];

                for (int i = 0; i < top5.Length; i++)
                {
                    totalSuppliers[i] = top5[i];
                }

                totalSuppliers[5] = new SuppliersPurchases
                {
                    Name = "Altri",
                    Total = others
                };
            }
            else
            {
                totalSuppliers = suppliersData;
            }
            
            return totalSuppliers;
        }
    }
}