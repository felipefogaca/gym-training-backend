using GymTraining.Domain.Common.Commands;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public class CreateTrainingInput : IRequest<GenericOutput<CreateTrainingOutput>>
    {
        public string Name { get;  set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get;  set; }
        public DateOnly EndDate { get;  set; }
    }
}
