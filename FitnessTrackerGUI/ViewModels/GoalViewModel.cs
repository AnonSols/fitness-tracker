using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessTrackerGUI.Views;
namespace FitnessTrackerGUI.ViewModels;

public partial class GoalViewModel : ObservableObject
{
    [ObservableProperty]
    private string calorieGoal = string.Empty;

    [ObservableProperty]
    private string stepsGoal = string.Empty;

    [ObservableProperty]
    private string feedbackMessage = string.Empty;

    [RelayCommand]
    private void SaveGoal()
    {
        if (string.IsNullOrWhiteSpace(CalorieGoal) || string.IsNullOrWhiteSpace(StepsGoal))
        {
            FeedbackMessage = "Please fill in both fields.";
            return;
        }

        FeedbackMessage = $"Goal saved: {CalorieGoal} kcal, {StepsGoal} steps.";
        App.MainViewModel.CurrentView = new ActivityView();

        // Later: store in a service or model if needed
    }
}
