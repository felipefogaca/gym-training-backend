using GymTraining.Domain.Infra.Data.EF.Configurations;
using GymTraining.Domain.Infra.Data.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace GymTraining.Domain.Infra.Data.EF
{
    public class GymTrainingDbContext : DbContext
    {
        
        public GymTrainingDbContext(DbContextOptions<GymTrainingDbContext> options) : base(options)
        {
            Trainings = Set<TrainingModel>();
        }

        public DbSet<TrainingModel> Trainings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrainingConfiguration());
        }
    }
}
