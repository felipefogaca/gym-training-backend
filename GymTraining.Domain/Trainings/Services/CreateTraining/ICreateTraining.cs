using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Services.Common;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public interface ICreateTraining : IRequestHandler<CreateTrainingInput, GenericOutput<TrainingOutput>>
    {
        
    }
}
