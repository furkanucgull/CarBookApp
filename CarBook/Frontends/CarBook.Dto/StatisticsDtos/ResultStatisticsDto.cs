namespace CarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BlogCount { get; set; }
        public int BrandCount { get; set; }
        public decimal avgPriceForDaily { get; set; }
        public decimal avgRentPriceForMonthly { get; set; }
        public decimal avgRentPriceForWeekly { get; set; }
        public int carCountByElectric { get; set; }
        public int carCountByKmLower1000 { get; set; }
        public int carCountByTransmissionisAuto { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        
    }
}
