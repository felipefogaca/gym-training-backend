using GymTraining.Domain.Common.SeedWork;

namespace GymTraining.Domain.Trainings.Entities
{
    public class Training : AggregateRoot
    {
        public Training(Guid id, string name, string description, DateOnly startDate, DateOnly endDate) : base(id)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

            Validate();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
            Validate();
        }

        public void ChangeDescription(string description)
        {
            Description = description;
            Validate();
        }

        public void ChangeStartAndEndDate(DateOnly startDate, DateOnly endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
            Validate();
        }

        public void Validate()
        {
            //validate entity
        }
    }
}
