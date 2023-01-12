using GymTraining.Domain.Common.SeedWork;

namespace GymTraining.Domain.Exercicies.Entities
{
    public class Exercicie : Entity
    {
        public Exercicie(Guid id, string name, string description, string image, bool isActive) : base(id)
        {
            Name = name;
            Description = description;
            Image = image;
            IsActive = isActive;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public bool IsActive { get; private set; }

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

        public void ChangeImage(string image)
        {
            Image = image;
            Validate();
        }

        public void Active()
        {
            IsActive = true;
        }

        public void Deactive()
        {
            IsActive = false;
        }

        public void Validate()
        {
            //  validate entity
        }
    }
}
