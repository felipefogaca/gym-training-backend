using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Repositories;
using GymTraining.Domain.Trainings.Services.Common;

namespace GymTraining.Domain.Trainings.Services.UpdateTraining
{
    public class UpdateTraining : IUpdateTraining
    {
        private readonly ITrainingsRepository _trainingsRepository;
        public UpdateTraining(ITrainingsRepository trainingsRepository)
        {
            _trainingsRepository = trainingsRepository;
        }

        public async Task<GenericOutput<TrainingOutput>> Handle(UpdateTrainingInput request, CancellationToken cancellationToken)
        {
            var training = await _trainingsRepository.Find(request.Id);

            if(training is null)
            {
                return new GenericOutput<TrainingOutput>(false, "Not found");
            }

            training.ChangeStartDate(request.StartDate);
            training.ChangeEndDate(request.EndDate);
            training.ChangeDescription(request.Description);
            training.ChangeName(request.Name);

            await _trainingsRepository.Update(training);


            return new GenericOutput<TrainingOutput>(true, "Success to update");

        }
    }
}
