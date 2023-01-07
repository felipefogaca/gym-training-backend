using GymTraining.Domain.Common.Commands;
using GymTraining.Domain.Trainings.Services.Common;
using MediatR;

namespace GymTraining.Domain.Trainings.Services.FindTraining
{
    public interface IFindTrainingService : IRequestHandler<FindTrainingInput, GenericOutput<TrainingOutput>>
    {

    }
}
