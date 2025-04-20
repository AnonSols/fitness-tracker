using Avalonia.Controls;
using FitnessTrackerGUI.ViewModels;
namespace FitnessTrackerGUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}