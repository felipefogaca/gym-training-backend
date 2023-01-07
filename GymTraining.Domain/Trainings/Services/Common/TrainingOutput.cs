using GymTraining.Domain.Trainings.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTraining.Domain.Trainings.Services.Common
{
    public class TrainingOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public static TrainingOutput FromEntity(Training training)
        {
            return new TrainingOutput()
            {
                Id = training.Id,
                Name = training.Name,
                Description = training.Description,
                StartDate = training.StartDate,
                EndDate = training.EndDate,
            };
        }
    }
}
