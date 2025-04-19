using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessTrackerGUI.Views;

namespace FitnessTrackerGUI.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty]
    private string welcomeMessage = "Welcome to your Dashboard 🎯";

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
