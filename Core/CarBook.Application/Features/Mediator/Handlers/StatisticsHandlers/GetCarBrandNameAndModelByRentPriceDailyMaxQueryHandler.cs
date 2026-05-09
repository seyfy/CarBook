using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetCarBrandNameAndModelByRentPriceDailyMaxQueryHandler:IRequestHandler< GetCarBrandNameAndModelByRentPriceDailyMaxQuery,  GetCarBrandNameAndModelByRentPriceDailyMaxQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public  GetCarBrandNameAndModelByRentPriceDailyMaxQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task< GetCarBrandNameAndModelByRentPriceDailyMaxQueryResult> Handle( GetCarBrandNameAndModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
        {
            var value = _repository. GetCarBrandNameAndModelByRentPriceDailyMax();
            return new  GetCarBrandNameAndModelByRentPriceDailyMaxQueryResult
            {
                CarBrandNameAndModelByRentPriceDailyMax = value
            };
        }
    }
}
