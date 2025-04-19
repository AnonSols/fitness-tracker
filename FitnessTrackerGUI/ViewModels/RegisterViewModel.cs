using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FitnessTrackerGUI.Services;
using FitnessTrackerGUI.Views;
using FitnessTrackerGUI.Helpers; 

namespace FitnessTrackerGUI.ViewModels;

public partial class RegisterViewModel : ObservableObject
{
    [ObservableProperty]
    private string username = string.Empty;

    [ObservableProperty]
    private string password = string.Empty;

    [ObservableProperty]
    private string confirmPassword = string.Empty;

    [ObservableProperty]
    private string errorMessage = string.Empty;

    [RelayCommand]
    private void Register()
    {
        if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfirmPassword))
        {
            ErrorMessage = "All fields are required.";
            return;
        }

        if (!ValidationHelper.IsValidPassword(Password))
{
    ErrorMessage = "Password must be 12 characters with 1 uppercase and 1 lowercase letter.";
    return;
}

        if (Password != ConfirmPassword)
        {
            ErrorMessage = "Passwords do not match.";
            return;
        }

        if (UserService.UserExists(Username))
        {
            ErrorMessage = "User already exists.";
            return;
        }

        UserService.Register(Username, Password);
        ErrorMessage = "Registration successful!";
        App.MainViewModel.CurrentView = new LoginView(); // Optional auto-redirect
    }
}
