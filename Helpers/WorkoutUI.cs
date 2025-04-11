namespace FitnessTrackerApp.Helpers;
using FitnessTrackerApp.Services;
public static class WorkoutUI
{
    public static void WorkoutMenu(WorkoutService service)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Workout Dashboard");
            Console.WriteLine("1. Log a workout");
            Console.WriteLine("2. View all workouts");
            Console.WriteLine("3. Back  to Main Menu");
            Console.WriteLine("Select an Option: ");

            string choice = Console.ReadLine()!;


        }
    }
}

private static void LogWorkout(WorkoutService service)
    {
        Console.WriteLine("Select Activity Type: ");
        Console.WriteLine("1. Walking");
        Console.WriteLine("2. Swimming");
        Console.Write("Enter activity number: ");

        if (int.TryParse(Console.ReadLine(), out int activityType))
        {
            switch (activityType)
            {


            }
        }
    }