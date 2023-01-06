namespace GymTraining.Domain.Common.Entities
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Entity(Guid id)
        {
            if(id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }

            Id = id;
        }
    }
}
