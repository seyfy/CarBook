using CarBook.Application.Features.ViewModels;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Persistence.Context;
using CarBook_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

		public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingID == 4).ToList();
            return values;
        }

		public List<CarPricing> GetCarPricingWithTimePeriod()
		{
			throw new NotImplementedException();
		}

		public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
		{
			List<CarPricingViewModel> values = new List<CarPricingViewModel>();
			using (var command = _context.Database.GetDbConnection().CreateCommand())
			{
				command.CommandText = "Select *from(Select CoverImageUrl,Model,PricingID,Amount From CarPricings Inner Join Cars on Cars.CarID=CarPricings.CarID Inner Join Brands on Brands.BrandID=Cars.BrandID) as SourceTable Pivot(Sum(Amount) For PricingID In ([4],[5],[8])) as PivotTable;";
				command.CommandType = System.Data.CommandType.Text;
				_context.Database.OpenConnection();
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                        {
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amounts = new List<decimal>
                            {
                                Convert.ToDecimal(reader[2]),
                                Convert.ToDecimal(reader[3]),
                                Convert.ToDecimal(reader[4])

                            }
                        };
                        values.Add(carPricingViewModel);
					}
				}
				_context.Database.CloseConnection();
				return values;
			}
		}

	}  
	
}



//var values = from x in _context.CarPricings
//             group x by x.PricingID into g
//             select new
//             {
//                 CarId = g.Key,
//                 DailyPrice = g.Where(y => y.CarPricingID == 4).Sum(z => z.Amount),
//                 WeeklyPrice = g.Where(y => y.CarPricingID == 5).Sum(z => z.Amount),
//                 MonthlyPrice = g.Where(y => y.CarPricingID == 8).Sum(z => z.Amount)
//             };
//return 0;


/*public List<CarPricing> CarPricingWithTimePeriod()
{
    List<CarPricing> values = new List<CarPricing>();
    using (var command = _context.Database.GetDbConnection().CreateCommand())
    {
        command.CommandText = "Select *from(Select Model,PricingID,Amount From CarPricings Inner Join Cars on Cars.CarID=CarPricings.CarID Inner Join Brands on Brands.BrandIS=Cars.BrandID) as SourceTable Pivot(Sum(Amount) For PricingID In ([4],[5],[8])) as PivotTable;";
        command.CommandType = System.Data.CommandType.Text();
        _context.Database.OpenConnection();
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                CarPricing carPricing = new CarPricing();
                Enumerable.Range(1, 3).ToList().ForEach(x =>
                {
                    if (DBNull.Value.Equals(reader[x]))
                    {
                        carPricing.

                    }
                    else
                    {
                        carPricing.Amount

                    }
                });
                values.Add(carPricing);
            }
        }
        _context.Database.CloseConnection();
        return values;
    }
}
*/