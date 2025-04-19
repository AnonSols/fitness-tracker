using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessTrackerGUI.Views;
using System.Collections.ObjectModel;
using FitnessTrackerGUI.Services; // For AnalyticsService
using System.Collections.Generic;
using System.Linq;
namespace FitnessTrackerGUI.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    public ObservableCollection<string> RecentActivitiesCollection { get; } = new();

    [ObservableProperty]
    private string welcomeMessage = "Welcome to your Dashboard 🎯";

    [ObservableProperty]
    private int dailyCalorieGoal = 2500;

    [ObservableProperty]
    private double caloriesBurned = 0;
    [ObservableProperty]
    private double totalCalories = AnalyticsService.TotalCaloriesBurned;

    [ObservableProperty]
    private List<string> activityBreakdown = AnalyticsService.CaloriesByActivity
        .Select(kvp => $"{kvp.Key}: {kvp.Value:F1} kcal")
        .ToList();

    [ObservableProperty]
    private List<string> recentActivities = AnalyticsService.GetLogs()
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

    // Optional: To simulate activity summary being added
    public void AddActivity(string summary, double calories)
    {
        RecentActivitiesCollection.Insert(0, summary);
        CaloriesBurned += calories;
    }
}
// This class is the ViewModel for the DashboardView. It contains properties and commands that are bound to the UI elements in the DashboardView.axaml file. The ViewModel is responsible for handling user interactions and updating the UI accordingly.