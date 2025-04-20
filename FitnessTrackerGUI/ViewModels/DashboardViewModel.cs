using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessTrackerGUI.Views;
using FitnessTrackerGUI.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FitnessTrackerGUI.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty]
    private string welcomeMessage = "Welcome to your Dashboard 🎯";

    [ObservableProperty]
    private int dailyCalorieGoal = 2500;

    public double CaloriesBurned => AnalyticsService.TotalCaloriesBurned;

    public List<string> ActivityBreakdown =>
        AnalyticsService.CaloriesByActivity
            .Select(kvp => $"{kvp.Key}: {kvp.Value:F1} kcal")
            .ToList();

    public List<string> RecentActivities =>
        AnalyticsService.GetLogs()
            .OrderByDescending(a => a.Timestamp)
            .Take(5)
            .Select(a => $"{a.Timestamp:t} - {a.ActivityType} - {a.CaloriesBurned:F1} kcal")
            .ToList();

    [RelayCommand]
    private void GoToActivity()
    {
        App.MainViewModel.CurrentView = new ActivityView();
    }

    [RelayCommand]
    private void Logout()
    {
        App.MainViewModel.CurrentView = new LoginView();
    }
}
