using System;
namespace FitnessTrackerGUI.Models;

public class Workout
{
    public string WorkoutName { get; set; }
    public int DurationInMinutes { get; set; }
    public DateTime Date { get; set; }

    public Workout(string name, int durationInMinutes)
    {
        WorkoutName = name;
        DurationInMinutes = durationInMinutes;
        Date = DateTime.Now;
    }

}
