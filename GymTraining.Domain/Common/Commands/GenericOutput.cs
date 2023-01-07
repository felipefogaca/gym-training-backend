namespace GymTraining.Domain.Common.Commands
{
    public class GenericOutput<T>
    {
        public GenericOutput(bool success, string message, T? data = default)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; private set; }
        public string Message { get; private set; }
        public T? Data { get; set; }
    }
}
