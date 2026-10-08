using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;
using CarBook.Persistence.Repositories.CommentRepositories;
using CarBook.Persistence.Repositories.CarRepositories;
using Microsoft.Extensions.DependencyInjection;
using CarBook.Application.Features.RepositoryPattern;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Application.Interfaces.ReviewInterfaces;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Persistence.Repositories.BlogRepositories;
using CarBook.Persistence.Repositories.CarDescriptionRepositories;
using CarBook.Persistence.Repositories.CarFeatureRepositories;
using CarBook.Persistence.Repositories.CarPricingRepositories;
using CarBook.Persistence.Repositories.RentACarRepositories;
using CarBook.Persistence.Repositories.ReviewRepositories;
using CarBook.Persistence.Repositories.StatisticsRepositoies;
using CarBook.Persistence.Repositories.TagCloudRepositories;

namespace CarBook.WebApi.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddProjectServices(
            this IServiceCollection services)
        {
            // DbContext
            services.AddScoped<CarBookContext>();

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
            services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
            services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
            services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
            services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
            services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
            services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
            services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
            services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
            services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));

            // About
            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<CreateAboutCommandHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();

            // Banner
            services.AddScoped<GetBannerQueryHandler>();
            services.AddScoped<GetBannerByIdQueryHandler>();
            services.AddScoped<CreateBannerCommandHandler>();
            services.AddScoped<UpdateBannerCommandHandler>();
            services.AddScoped<RemoveBannerCommandHandler>();

            // Brand
            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();
            services.AddScoped<GetBrandCarCountQueryHandler>();

            // Car
            services.AddScoped<GetCarQueryHandler>();
            services.AddScoped<GetCarByIdQueryHandler>();
            services.AddScoped<CreateCarCommandHandler>();
            services.AddScoped<UpdateCarCommandHandler>();
            services.AddScoped<RemoveCarCommandHandler>();
            services.AddScoped<GetBlogWithBrandQueryHandler>();
            services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

            // Category
            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();

            // Contact
            services.AddScoped<GetContactQueryHandler>();
            services.AddScoped<GetContactByIdQueryHandler>();
            services.AddScoped<CreateContactCommandHandler>();
            services.AddScoped<UpdateContactCommandHandler>();
            services.AddScoped<RemoveContactCommandHandler>();

            return services;
        }
    }
}