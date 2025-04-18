namespace FitnessTrackerGUI.Models.Activities;

public class Cycling : Activity
{
    public double DistanceKm { get; set; }
    public int DurationMinutes { get; set; }
    public int AvgSpeedKmh { get; set; }

    public override double CalculateCaloriesBurned()
        => DistanceKm * 30;  // ~30 kcal/km for moderate cycling
}