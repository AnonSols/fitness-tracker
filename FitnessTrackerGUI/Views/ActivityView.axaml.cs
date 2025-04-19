using Avalonia.Controls;
using FitnessTrackerGUI.ViewModels;

namespace FitnessTrackerGUI.Views;

public partial class ActivityView : UserControl
{
    public ActivityView()
    {
        InitializeComponent();
        DataContext = new ActivityViewModel();

    }
}
