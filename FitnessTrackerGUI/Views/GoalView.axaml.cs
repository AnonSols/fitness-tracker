using Avalonia.Controls;
using FitnessTrackerGUI.ViewModels;

namespace FitnessTrackerGUI.Views;

public partial class GoalView : UserControl
{
    public GoalView()
    {
        InitializeComponent();
        DataContext = new GoalViewModel();
    }
}
