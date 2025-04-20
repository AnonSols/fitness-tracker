using Avalonia.Controls;
using FitnessTrackerGUI.ViewModels;

namespace FitnessTrackerGUI.Views;

public partial class RegisterView : UserControl
{
    public RegisterView()
    {
        InitializeComponent();
        DataContext = new ViewModels.RegisterViewModel();
    }
}
