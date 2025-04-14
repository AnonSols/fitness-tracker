namespace FitnessTrackerApp.Model.Activities;

public class Walking : Activity
{
    public int Steps { get; set; }
    public double DistanceKm { get; set; }
    public int DurationMinutes { get; set; }

    public override double CalculateCaloriesBurned() => Steps * 0.04;
}

