using GymTraining.Domain.Infra.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace GymTraining.Domain.Api.Configurations
{
    public static class ConnectionsConfiguration
    {
        public static IServiceCollection AddAppConnections(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbConnection(configuration);

            return services;
        }

        private static IServiceCollection AddDbConnection(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Default");

            services.AddDbContext<GymTrainingDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
