using Avalonia.Controls;
using FitnessTrackerGUI.ViewModels;

namespace FitnessTrackerGUI.Views;

public partial class LoginView : UserControl
{
    public LoginView()
    {
        InitializeComponent();
        DataContext = new ViewModels.LoginViewModel();
    }
}
