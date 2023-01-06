using MediatR;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public interface ICreateTrainingService : IRequestHandler<CreateTrainingInput, CreateTrainingOutput>
    {
        
    }
}
