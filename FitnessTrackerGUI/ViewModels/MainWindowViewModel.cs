using CommunityToolkit.Mvvm.ComponentModel;
using FitnessTrackerGUI.Views;

namespace FitnessTrackerGUI.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private object currentView;

    public MainWindowViewModel()
    {
        CurrentView = new LoginView();
    }
}
