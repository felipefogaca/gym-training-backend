using GymTraining.Domain.Common.Entities;

namespace GymTraining.Domain.Trainings.Entities
{
    public class Training : Entity
    {
        public Training(Guid id, string name, string description, DateOnly startDate, DateOnly endDate) : base(id)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangeDescription(string description)
        {
            Description = description;
        }

        public void ChangeStartDate(DateOnly startDate)
        {
            StartDate = startDate;
        }

        public void ChangeEndDate(DateOnly endDate)
        {
            EndDate = endDate;
        }
    }
}
