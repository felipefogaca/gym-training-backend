using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Services.Common;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public interface ICreateTrainingService : IRequestHandler<CreateTrainingInput, GenericOutput<TrainingOutput>>
    {
        
    }
}
