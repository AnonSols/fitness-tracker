using CommunityToolkit.Mvvm.ComponentModel;
using System;
using CommunityToolkit.Mvvm.Input;
using FitnessTrackerGUI.Services;
using System.Threading.Tasks;
using FitnessTrackerGUI.Views;
namespace FitnessTrackerGUI.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    private string username = string.Empty;

    [ObservableProperty]
    private string password = string.Empty;

    [ObservableProperty]
    private string errorMessage = string.Empty;

    [RelayCommand]
    public void NavigateToRegister()
    {
        App.MainViewModel.CurrentView = new RegisterView();
    }

    [RelayCommand]
    public async Task Login()
    {
        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
        {
            ErrorMessage = "Please enter both username and password.";
            return;
        }

        ErrorMessage = "";

        try
        {
            if (UserService.Authenticate(Username, Password))
            {
                ErrorMessage = "✓ Login successful";
                await Task.Delay(800);
                App.MainViewModel.CurrentView = new GoalView();
            }
            else
            {
                ErrorMessage = "Invalid credentials";
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Error: {ex.Message}";
        }
    }
}
