using GymTraining.Domain.Infra.Data.EF.Repositories;
using GymTraining.Domain.Trainings.Repositories;
using GymTraining.Domain.Trainings.Services.FindTraining;
using MediatR;

namespace GymTraining.Domain.Api.Configurations
{
    public static class DomainServicesConfiguration
    {

        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(FindTrainingService));
            services.AddRepositories();

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITrainingsRepository, TrainingsRepository>();

            return services;
        }
    }
}
