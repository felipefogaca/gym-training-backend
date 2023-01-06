namespace GymTraining.Domain.Common.Responses
{
    public class Output<T>
    {
        
        public Output(T data)
        {
            Data = data;
            HasError = false;
            Message = string.Empty;
            Errors = new List<string>();
        }

        public Output(string message, List<string> errors)
        {
            Data = default;
            HasError = true;
            Message = message;
            Errors = errors;
        }


        public T? Data { get; private set; }
        public bool HasError { get; private set; }
        public string Message { get; private set; }
        public List<string> Errors { get; private set; }
    }
}
