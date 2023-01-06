﻿namespace GymTraining.Domain.Trainings.Services.CreateTraining
{
    public class CreateTrainingInput
    {
        public string Name { get;  set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly StartDate { get;  set; }
        public DateOnly EndDate { get;  set; }
    }
}