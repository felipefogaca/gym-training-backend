using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Exercicies.Entities;
using GymTraining.Domain.Exercicies.Repositories;
using GymTraining.Domain.Exercicies.Services.Common;

namespace GymTraining.Domain.Exercicies.Services.CreateExecicie
{
    public class CreateExercicieService : ICreateExercicieService
    {
        private readonly IExerciciesRepository _exerciciesRepository;

        public CreateExercicieService(IExerciciesRepository exerciciesRepository)
        {
            _exerciciesRepository = exerciciesRepository;
        }

        public async Task<GenericOutput<ExercicieOutput>> Handle(CreateExercicieInput request, CancellationToken cancellationToken)
        {
            var exercicie = new Exercicie(
                id: Guid.Empty,
                name: request.Name,
                description: request.Description,
                image: request.Image,
                isActive: request.IsActive
                );


            await _exerciciesRepository.Create(exercicie);

            var output = ExercicieOutput.FromEntity(exercicie);

            return new GenericOutput<ExercicieOutput>(true, "Exercicie saved", output);
        }
    }
}
