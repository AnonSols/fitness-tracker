namespace FitnessTrackerApp.Helpers;

public static class MenuUI
{

    public static void ShowMainMenu()
    {
        Console.WriteLine(" Fitness Tracker");
        Console.WriteLine(" 1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Exit");
        Console.Write("Select an option: ");

    }

    public static void ShowError(string message)
    {
        Console.WriteLine($"Error: {message}");
        Console.ReadKey();
    }
}