using GymTraining.Domain.Trainings.Entities;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public class CreateTrainingOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public static CreateTrainingOutput FromEntity(Training training)
        {
            return new CreateTrainingOutput()
            {
                Id = training.Id,
                Name = training.Name,
                Description = training.Description,
                StartDate = training.StartDate,
                EndDate = training.EndDate,
            };
        }
    }
}
