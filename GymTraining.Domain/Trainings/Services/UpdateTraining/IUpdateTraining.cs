using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Services.Common;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.UpdateTraining
{
    public interface IUpdateTraining : IRequestHandler<UpdateTrainingInput, GenericOutput<TrainingOutput>>
    {
    }
}
