namespace FitnessTrackerApp.Helpers;

using FitnessTrackerApp.Models.Activities;
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
            Console.WriteLine("3. Set Calorie Goal");
            Console.WriteLine("4. Back  to Main Menu");
            Console.WriteLine("Select an Option: ");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    LogWorkout(service);
                    break;
                case "2":
                    ViewAllWorkouts(service);
                    break;
                case "3":
                    SetCalorieGoal(service);
                    break;
                case "4":
                    return;
                default:
                    MenuUI.ShowError("Invalid choice. Please try again.");
                    break;


            }

        }
    }

    private static void LogWorkout(WorkoutService service)
    {
        Console.WriteLine("Select Activity:");
        Console.WriteLine("1. Walking");
        Console.WriteLine("2. Swimming");
        Console.WriteLine("3. Running");
        Console.WriteLine("4. Cycling");
        // Console.WriteLine("5. Yoga");
        // Console.WriteLine("6. Weightlifting");
        Console.Write("Enter activity number: ");

        if (int.TryParse(Console.ReadLine(), out int activityType))
        {
            switch (activityType)
            {
                case 1:
                    LogWalkingWorkout(service);
                    break;
                case 2:
                    LogSwimmingWorkout(service);
                    break;
                case 3:
                    LogRunningWorkout(service);
                    break;
                case 4:
                    LogCyclingWorkout(service);
                    break;
                // case 5:
                //     LogYogaWorkout(service);
                //     break;
                // case 6:
                //     LogWeightliftingWorkout(service);
                //     break;
                default:
                    MenuUI.ShowError("Invalid activity type!");
                    break;
            }
        }
    }
    private static void ViewAllWorkouts(WorkoutService service)
    {
        Console.WriteLine("All Workouts: ");
        service.ListWorkouts();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    private static void LogWalkingWorkout(WorkoutService service)
    {
        Console.Write("Enter steps: ");
        int steps = int.Parse(Console.ReadLine()!);
        Console.Write("Enter duration (km): ");
        double distance = double.Parse(Console.ReadLine()!);
        Console.Write("Enter duration  (minutes): ");
        int duration = int.Parse(Console.ReadLine()!);

        service.LogActivity(new Walking
        {
            Steps = steps,
            DistanceKm = distance,
            DurationMinutes = duration
        });

        Console.WriteLine("Walking workout logged successfully!");
        Console.ReadKey();
    }


    private static void LogSwimmingWorkout(WorkoutService service)
    {
        Console.Write("Enter laps: ");
        int laps = int.Parse(Console.ReadLine()!);
        Console.Write("Enter duration (minutes): ");
        int duration = int.Parse(Console.ReadLine()!);
        Console.Write("Enter aveg heart rate: ");
        int heartRate = int.Parse(Console.ReadLine()!);

        service.LogActivity(new Swimming
        {
            Laps = laps,
            DurationMinutes = duration,
            AvgHeartRate = heartRate
        });

        Console.WriteLine("Swimming workout logged successfully!");
        Console.ReadKey();
    }

    private static void LogCyclingWorkout(WorkoutService service)
    {
        Console.Write("Enter distance (km): ");
        double distance = double.Parse(Console.ReadLine()!);
        Console.Write("Enter duration (minutes): ");
        int duration = int.Parse(Console.ReadLine()!);
        Console.Write("Enter aveg heart rate: ");
        int speed = int.Parse(Console.ReadLine()!);

        service.LogActivity(new Cycling
        {
            DistanceKm = distance,
            DurationMinutes = duration,
            AvgSpeedKmh = speed
        });

        Console.WriteLine("Cycling workout logged successfully!");
        Console.ReadKey();
    }
    private static void LogRunningWorkout(WorkoutService service)
    {
        Console.Write("Enter distance (km): ");
        double distance = double.Parse(Console.ReadLine()!);
        Console.Write("Enter duration (minutes): ");
        int duration = int.Parse(Console.ReadLine()!);
        Console.Write("Enter aveg heart rate: ");
        int elevation = int.Parse(Console.ReadLine()!);

        service.LogActivity(new Running
        {
            DistanceKm = distance,
            DurationMinutes = duration,
            ElevationGain = elevation
        });

        Console.WriteLine("Running workout logged successfully!");
        Console.ReadKey();
    }
    private static void SetCalorieGoal(WorkoutService service)
    {
        Console.Write("Enter dsaily calorie goal: ");
        if (int.TryParse(Console.ReadLine(), out int goal))
        {
            service.SetCalorieGoal(goal);
            Console.WriteLine($"Goal set to {goal} kcal!");
        }
        else
        {
            MenuUI.ShowError("Invalid Input");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

}

