using System.Collections.Generic;
using FitnessTrackerGUI.Models;
using System.Linq;
namespace FitnessTrackerGUI.Services;

public static class AnalyticsService
{
    private static List<ActivityLog> _logs = new();

    public static void AddLog(ActivityLog log) => _logs.Add(log);

    public static IEnumerable<ActivityLog> GetLogs() => _logs;

    public static double TotalCaloriesBurned =>
        _logs.Sum(log => log.CaloriesBurned);

    public static Dictionary<string, double> CaloriesByActivity =>
        _logs
            .GroupBy(log => log.ActivityType)
            .ToDictionary(g => g.Key, g => g.Sum(log => log.CaloriesBurned));
}
