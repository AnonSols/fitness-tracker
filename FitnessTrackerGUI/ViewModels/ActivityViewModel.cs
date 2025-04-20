using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using FitnessTrackerGUI.Views;
using FitnessTrackerGUI.Models; // NEW: For ActivityLog model
using FitnessTrackerGUI.Services; // NEW: For AnalyticsService
using System;

namespace FitnessTrackerGUI.ViewModels;

public partial class ActivityViewModel : ObservableObject
{
    public ActivityViewModel()
    {
        SelectedActivityType = string.Empty;
        Steps = string.Empty;
        DistanceKm = string.Empty;
        DurationMinutes = string.Empty;
        ElevationGain = string.Empty;
        CaloriesText = "Calories: -";

        UpdateInputs();
    }

    public ObservableCollection<string> ActivityTypes { get; } = new()
    {
        "Running", "Yoga", "Swimming", "Weightlifting", "Cycling", "Walking"
    };

    [ObservableProperty] private string selectedActivityType = string.Empty;
    [ObservableProperty] private string steps = string.Empty;
    [ObservableProperty] private string distanceKm = string.Empty;
    [ObservableProperty] private string durationMinutes = string.Empty;
    [ObservableProperty] private string elevationGain = string.Empty;
    [ObservableProperty] private string caloriesText = "Calories: -";

    // NEW: Proper log collection for analytics
    public ObservableCollection<ActivityLog> ActivityLogs { get; } = new();

    partial void OnSelectedActivityTypeChanged(string value) => UpdateInputs();

    private void UpdateInputs()
    {
        ShowSteps = SelectedActivityType == "Walking";
        ShowDistance = SelectedActivityType is "Running" or "Cycling";
        ShowDuration = SelectedActivityType != "Yoga";
        ShowElevation = SelectedActivityType == "Running";
    }

    [ObservableProperty] private bool showSteps;
    [ObservableProperty] private bool showDistance;
    [ObservableProperty] private bool showDuration;
    [ObservableProperty] private bool showElevation;

    [RelayCommand]
    private void LogActivity()
    {
        double calories = CalculateCalories();
        CaloriesText = $"Calories: {calories:F1}";
        double.TryParse(Steps, out double s);
        double.TryParse(DistanceKm, out double d);
        double.TryParse(DurationMinutes, out double t);
        double.TryParse(ElevationGain, out double e);
        var log = new ActivityLog
        {
            ActivityType = SelectedActivityType,
            Steps = s,
            DistanceKm = d,
            DurationMinutes = t,
            ElevationGain = e,
            CaloriesBurned = calories,
            Timestamp = DateTime.Now
        };



        ActivityLogs.Add(log);
        AnalyticsService.AddLog(log); // Save to analytics
    }

    [RelayCommand]
    private void BackToDashboard()
    {
        App.MainViewModel.CurrentView = new DashboardView();
    }

    private double CalculateCalories()
    {
        double.TryParse(Steps, out double s);
        double.TryParse(DistanceKm, out double d);
        double.TryParse(DurationMinutes, out double t);
        double.TryParse(ElevationGain, out double e);

        return SelectedActivityType switch
        {
            "Walking" => s * 0.04,
            "Running" => (d * 60) + (e * 0.5),
            "Cycling" => d * 50,
            "Swimming" => t * 9.8,
            "Weightlifting" => t * 5.5,
            "Yoga" => 3.0,
            _ => 0
        };
    }
}
