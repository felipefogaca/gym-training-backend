using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Exercicies.Services.Common;
using MediatR;

namespace GymTraining.Domain.Exercicies.Services.CreateExecicie
{
    public interface ICreateExercicieService : IRequestHandler<CreateExercicieInput, GenericOutput<ExercicieOutput>>
    {

    }
}
