using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandCarCountQueryHandler
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Brand> _brandRepository;

        public GetBrandCarCountQueryHandler(
            IRepository<Car> carRepository,
            IRepository<Brand> brandRepository)
        {
            _carRepository = carRepository;
            _brandRepository = brandRepository;
        }

        public async Task<List<GetBrandCarCountQueryResult>> Handle()
        {
            var brands = await _brandRepository.GetAllAsync();
            var cars = await _carRepository.GetAllAsync();

            var values = brands.Select(brand => new GetBrandCarCountQueryResult
            {
                BrandName = brand.Name,
                CarCount = cars.Count(car => car.BrandID == brand.BrandID)
            }).ToList();

            return values;
        }
    }
}
