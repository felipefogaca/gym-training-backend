namespace GymTraining.Domain.Infra.Data.EF.Models
{
    public class TrainingModel
    {
        public Guid Id { get; set; }
        public string Name { get;  set; } = string.Empty;
        public string Description { get; set; } = String.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
