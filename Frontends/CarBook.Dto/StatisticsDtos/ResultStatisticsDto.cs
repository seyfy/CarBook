using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int carCount { get; set; }
        public int locationCount { get; set; }
        public int authorCount { get; set; }
        public int blogCount { get; set; }
        public int brandCount { get; set; }
        public decimal avgRentPriceForDaily { get; set; }
        public decimal avgRentPriceForWeek { get; set; }
        public decimal avgRentPriceForMonthly { get; set; }
        public int carCountTransmissionIsAuto { get; set; }
        public int carCountByKmSmallerThen1000 { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string carBrandNameAndModelByRentPriceDailyMax { get; set; }
        public string carBrandNameAndModelByRentPriceDailyMin { get; set; }
        public string brandNameByMaxCar { get; set; }
        public string blogTitleByMaxBlogComment { get; set; }


    }
}
