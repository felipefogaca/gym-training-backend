using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Repositories;
using GymTraining.Domain.Trainings.Services.Common;

namespace GymTraining.Domain.Trainings.Services.FindTraining
{
    public class FindTrainingService : IFindTrainingService
    {

        private readonly ITrainingsRepository _trainingsRepository;

        public FindTrainingService(ITrainingsRepository trainingsRepository)
        {
            _trainingsRepository = trainingsRepository;
        }

        public async Task<GenericOutput<TrainingOutput>> Handle(FindTrainingInput request, CancellationToken cancellationToken)
        {
            var training = await _trainingsRepository.Find(request.Id);

            if (training == null)
            {
                return new GenericOutput<TrainingOutput>(false, "Not found", null);
            }

            var output = TrainingOutput.FromEntity(training);

            return new GenericOutput<TrainingOutput>(true, "Finded", output);
        }
    }
}
