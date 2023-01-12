namespace GymTraining.Domain.Common.SeedWork
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        public Entity(Guid id)
        {
            if (id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }

            Id = id;
        }
    }
}
