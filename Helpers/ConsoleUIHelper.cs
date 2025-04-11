using FitnessTrackerApp.Services;

namespace FitnessTrackerApp.Helpers;

public static class ConsoleUIHelper
{
    public static void AddWorkout(WorkoutService service)
    {
        Console.Write("Enter workout name (e.g., 'Morning Run'):  ");
        string name = Console.ReadLine()!.Trim();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty. Press any key to retry.");
            Console.ReadKey();
            return;
        }
        Console.Write("Enter duration (minutes): ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            service.AddWorkout(name, duration);
            Console.WriteLine("$ Workout {name} has been added! Press any key to continue.");
        }
        else
        {
            Console.WriteLine("Invalid duration. Press any key to retry");
        }
        Console.ReadKey();
    }

    public static void ViewAllWorkouts(WorkoutService service)
    {
        Console.WriteLine("All Workouts:");
        service.WorkoutList();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public static void WorkoutMenu(WorkoutService service)
    {
        Console.Clear();
        Console.WriteLine("Workout Dashboard");
        Console.WriteLine("1. Log a workout");
        Console.WriteLine("2. View all workouts");
        Console.WriteLine("3.Set Calorie Goal");
        Console.WriteLine("4. Back to Main Menu");
        Console.Write("Select an Option: ");

        string choice = Console.ReadLine()!;


    }


}