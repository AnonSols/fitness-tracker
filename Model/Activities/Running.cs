namespace FitnessTrackerApp.Model.Activites;

public class Running : Activity
{
    public double DistanceKm { get; set; }
    public int DurationMinutes { get; set; }
    public int ElevationGain { get; set; }

    public override double CalculateCaloriesBurned() => (DistanceKm * 60) + (ElevationGain * 0.5);
}