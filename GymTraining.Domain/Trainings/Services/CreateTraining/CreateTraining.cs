using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Entities;
using GymTraining.Domain.Trainings.Repositories;
using GymTraining.Domain.Trainings.Services.Common;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public class CreateTraining : ICreateTraining
    {

        private readonly ITrainingsRepository _trainingsRepository;
        public CreateTraining(ITrainingsRepository trainingsRepository)
        {
            _trainingsRepository = trainingsRepository;
        }

        public async Task<GenericOutput<TrainingOutput>> Handle(CreateTrainingInput input, CancellationToken cancellationToken)
        {
            var training = new Training(Guid.Empty,
                name: input.Name,
                description: input.Description,
                startDate: input.StartDate,
                endDate: input.EndDate);

            await _trainingsRepository.Create(training);


            var data = TrainingOutput.FromEntity(training);

            return new GenericOutput<TrainingOutput>(true, "Training saved", data);
        }
    }
}
