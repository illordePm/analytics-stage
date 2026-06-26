using analytics_backend.DTOs;

namespace analytics_backend.Helper
{
    public static class Filter
    {
        public static (int mesePrecedente, int annoPrecedente, int meseCorrente, int annoCorrente) ComparisonFilterHelper(Comparison comparisonMode, int month, int year)
        {
            int annoPrecedente;
            int mesePrecedente;

            int annoCorrente = year;
            int meseCorrente = month;

            switch (comparisonMode)
            {
                case Comparison.SameMonthPreviousYear:
                    //stesso mese dell'anno precedente
                    annoPrecedente = annoCorrente - 1;
                    mesePrecedente = meseCorrente;
                    break;

                default:
                case Comparison.PreviousMonth:
                    //caso default
                    var dataTemp = new DateTime(annoCorrente, meseCorrente, 1);
                    var dataPeriodoPrecedente = dataTemp.AddMonths(-1); //gestisce in automatico il cambio anno da gennaio a dicembre
                    annoPrecedente = dataPeriodoPrecedente.Year;
                    mesePrecedente = dataPeriodoPrecedente.Month;
                    break;
            }

            return (annoPrecedente, mesePrecedente, annoCorrente, meseCorrente);

        }
    }
}
