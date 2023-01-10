using GymTraining.Domain.Exercicies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTraining.Domain.Exercicies.Services.Common
{
    public class ExercicieOutput
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public static ExercicieOutput FromEntity(Exercicie exercicie)
        {
            return new ExercicieOutput
            {
                Id = exercicie.Id,
                Name = exercicie.Name,
                Description = exercicie.Description,
                Image = exercicie.Image,
                IsActive = exercicie.IsActive,
            };
        }
    }
}
