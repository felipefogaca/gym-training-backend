using GymTraining.Domain.Infra.Data.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymTraining.Domain.Infra.Data.EF.Configurations
{
    public class TrainingConfiguration : IEntityTypeConfiguration<TrainingModel>
    {
        public void Configure(EntityTypeBuilder<TrainingModel> builder)
        {

            builder.ToTable("Trainings");

            builder.Property(p => p.Id)
                .ValueGeneratedNever();

            builder.Property(p => p.Name)
                .HasColumnType("nvarchar(60)");

            builder.Property(p => p.Description)
                .HasColumnType("nvarchar(255)");

            builder.Property(p => p.StartDate)
                .HasColumnType("date");

            builder.Property(p => p.EndDate)
                .HasColumnType("date");
        }
    }
}
