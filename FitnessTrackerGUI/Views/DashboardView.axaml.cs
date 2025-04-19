using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FitnessTrackerGUI.Views;

public partial class DashboardView : UserControl
{
    public DashboardView()
    {
        InitializeComponent();
        DataContext = new ViewModels.DashboardViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
