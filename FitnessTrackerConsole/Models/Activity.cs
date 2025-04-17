namespace FitnessTrackerApp.Models;

public abstract class Activity
{


    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
    public abstract double CalculateCaloriesBurned();
}