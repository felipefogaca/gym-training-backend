using GymTraining.Domain.Common.Commands;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public interface ICreateTrainingService : IRequestHandler<CreateTrainingInput, GenericOutput<CreateTrainingOutput>>
    {
        
    }
}
