namespace GymTraining.Domain.Common.SeedWork
{
    public abstract class AggregateRoot : Entity
    {
        public AggregateRoot(Guid id) : base(id)
        {

        }
    }
}
