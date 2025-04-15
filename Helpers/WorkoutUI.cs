namespace FitnessTrackerApp.Helpers;

using FitnessTrackerApp.Services;
using FitnessTrackerApp.Helpers.WorkoutUIHelpers;
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
            Console.WriteLine("3. Set Calorie Goal");
            Console.WriteLine("4. Back  to Main Menu");
            Console.WriteLine("Select an Option: ");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    WorkoutHelpers.LogWorkout(service);
                    break;
                case "2":
                    WorkoutHelpers.ViewAllWorkouts(service);
                    break;
                case "3":
                    WorkoutHelpers.SetCalorieGoal(service);
                    break;
                case "4":
                    return;
                default:
                    MenuUI.ShowError("Invalid choice. Please try again.");
                    break;


            }

        }
    }




}

