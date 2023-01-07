using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Services.Common;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.FindTraining
{
    public class FindTrainingInput : IRequest<GenericOutput<TrainingOutput>>
    {
        public Guid Id { get; set; }
    }
}