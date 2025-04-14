namespace FitnessTrackerApp.Model.Activities;

public class Swimming : Activity
{
    public int Laps { get; set; }
    public int DurationMinutes { get; set; }
    public int AvgHeartRate { get; set; }

    public override double CalculateCaloriesBurned() => (Laps * 5) + (AvgHeartRate * 0.1 * DurationMinutes);
}