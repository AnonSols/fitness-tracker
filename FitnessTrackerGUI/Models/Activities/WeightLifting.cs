using FitnessTrackerGUI.Models;
namespace FitnessTrackerGUI.Models.Activities;

public class Weightlifting : Activity
{
    public string? Exercise { get; set; }  // e.g., "Deadlift", "Bench Press"
    public int Sets { get; set; }
    public int Reps { get; set; }
    public double WeightKg { get; set; }

    public override double CalculateCaloriesBurned()
        => (Sets * Reps * WeightKg * 0.03);  // Approx 0.03 kcal per kg per rep
}