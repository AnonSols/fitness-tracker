namespace FitnessTrackerGUI.Models.Activities;

public class Running : Activity
{
    public double DistanceKm { get; set; }
    public int DurationMinutes { get; set; }
    public int ElevationGain { get; set; }  // In meters

    public override double CalculateCaloriesBurned()
        => (DistanceKm * 60) + (ElevationGain * 0.5);  // 60 kcal/km + 0.5 kcal/m elevation
}