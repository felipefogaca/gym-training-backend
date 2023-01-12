using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Exercicies.Services.Common;
using MediatR;

namespace GymTraining.Domain.Exercicies.Services.CreateExecicie
{
    public class CreateExercicieInput : IRequest<GenericOutput<ExercicieOutput>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
