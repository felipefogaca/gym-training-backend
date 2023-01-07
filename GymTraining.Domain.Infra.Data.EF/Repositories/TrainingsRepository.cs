using GymTraining.Domain.Infra.Data.EF.Models;
using GymTraining.Domain.Trainings.Entities;
using GymTraining.Domain.Trainings.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GymTraining.Domain.Infra.Data.EF.Repositories
{
    public class TrainingsRepository : ITrainingsRepository
    {

        private readonly GymTrainingDbContext _dbContext;


        public TrainingsRepository(GymTrainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Training entity)
        {
            var model = new TrainingModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
            };

            _dbContext.Trainings.Add(model);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<Training?> Find(Guid id)
        {
            var model = await _dbContext.Trainings.FirstOrDefaultAsync(t => t.Id == id);

            if (model is null)
            {
                return null;
            }

            var training = new Training(
                id: model.Id,
                name: model.Name,
                description: model.Description,
                startDate: model.StartDate,
                endDate: model.EndDate);

            return training;
        }

        public async Task Update(Training entity)
        {
            var model = new TrainingModel()
            {
                Name = entity.Name,
                Description = entity.Description,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
            };

            _dbContext.Entry(model).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }
    }
}
