using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public interface ICreateTrainingService
    {
        public Task<CreateTrainingOutput> Handle(CreateTrainingInput input, CancellationToken cancellationToken);   
    }
}
