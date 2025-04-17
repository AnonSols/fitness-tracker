namespace FitnessTrackerApp.Models.Activities;
using FitnessTrackerApp.Models;

public class Yoga : Activity
{
    public string? Style { get; set; }  // e.g., "Vinyasa", "Hatha"
    public int DurationMinutes { get; set; }

    public override double CalculateCaloriesBurned()
        => DurationMinutes * 3.5;  // ~3.5 kcal/min for yoga
}