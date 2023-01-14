namespace GymTraining.Domain.Common.Exceptions
{
    public class EntityValidationException : Exception
    {
        public EntityValidationException(string message) : base(message)
        {

        }
    }
}
