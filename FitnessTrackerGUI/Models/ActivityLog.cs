using System;

namespace FitnessTrackerGUI.Models;

public class ActivityLog
{
    public string ActivityType { get; set; } = string.Empty;

    public double Steps { get; set; } = 0;

    public double DistanceKm { get; set; } = 0;

    public double DurationMinutes { get; set; } = 0;

    public double ElevationGain { get; set; } = 0;

    public double CaloriesBurned { get; set; } = 0;

    public DateTime Timestamp { get; set; } = DateTime.Now;

    public override string ToString()
    {
        return $"{Timestamp:t} - {ActivityType} - {CaloriesBurned:F1} kcal";
    }

}
