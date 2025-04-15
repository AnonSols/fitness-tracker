namespace FitnessTrackerApp.Helpers.WorkoutUIHelpers;
using FitnessTrackerApp.Services;
using FitnessTrackerApp.Models.Activities;
using FitnessTrackerApp.Helpers;
public static class WorkoutHelpers
{
    public static void LogWorkout(WorkoutService service)
    {
        Console.WriteLine("Select Activity:");
        Console.WriteLine("1. Walking");
        Console.WriteLine("2. Swimming");
        Console.WriteLine("3. Running");
        Console.WriteLine("4. Cycling");
        Console.WriteLine("5. Yoga");
        Console.WriteLine("6. Weightlifting");
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
                case 5:
                    LogYogaWorkout(service);
                    break;
                case 6:
                    LogWeightliftingWorkout(service);
                    break;
                default:
                    MenuUI.ShowError("Invalid activity type!");
                    break;
            }
        }
    }
    public static void ViewAllWorkouts(WorkoutService service)
    {
        Console.WriteLine("All Workouts: ");
        service.ListWorkouts();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
    public static void LogWalkingWorkout(WorkoutService service)
    {

        if (!ValidationHelper.TryReadPositiveInt("Enter steps: ", out int steps)) return;
        if (!ValidationHelper.TryReadPositiveDouble("Enter duration (km): ", out double distance)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter duration (minutes):  ", out int duration)) return;

        service.LogActivity(new Walking
        {
            Steps = steps,
            DistanceKm = distance,
            DurationMinutes = duration
        });

        Console.WriteLine("Walking workout logged successfully!");
        Console.ReadKey();
    }

    public static void LogSwimmingWorkout(WorkoutService service)
    {

        if (!ValidationHelper.TryReadPositiveInt("Enter laps: ", out int laps)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter duration (minutes): ", out int duration)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter average heart rate: ", out int heartRate)) return;

        service.LogActivity(new Swimming
        {
            Laps = laps,
            DurationMinutes = duration,
            AvgHeartRate = heartRate
        });

        Console.WriteLine("Swimming workout logged successfully!");
        Console.ReadKey();
    }

    public static void LogCyclingWorkout(WorkoutService service)
    {

        if (!ValidationHelper.TryReadPositiveDouble("Enter  distance(km): ", out double distance)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter duration (minutes): ", out int duration)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter aveg heart rate: ", out int speed)) return;

        service.LogActivity(new Cycling
        {
            DistanceKm = distance,
            DurationMinutes = duration,
            AvgSpeedKmh = speed
        });

        Console.WriteLine("Cycling workout logged successfully!");
        Console.ReadKey();
    }
    public static void LogRunningWorkout(WorkoutService service)
    {
        if (!ValidationHelper.TryReadPositiveDouble("Enter distance (km): ", out double distance)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter duration (minutes): ", out int duration)) return;
        if (!ValidationHelper.TryReadPositiveInt("Enter aveg heart rate: ", out int elevation)) return;

        service.LogActivity(new Running
        {
            DistanceKm = distance,
            DurationMinutes = duration,
            ElevationGain = elevation
        });

        Console.WriteLine("Running workout logged successfully!");
        Console.ReadKey();
    }

    public static void LogYogaWorkout(WorkoutService service)
    {
        // Console.Write("Enter duration (minutes): ");
        // string style = Console.ReadLine()!;
        // Console.Write("Enter aveg heart rate: ");
        // int duration = int.Parse(Console.ReadLine()!);

        service.LogActivity(new Yoga
        {
            Style = style,
            DurationMinutes = duration
        });

        Console.WriteLine("Yoga workout logged successfully!");
        Console.ReadKey();
    }

    public static void LogWeightliftingWorkout(WorkoutService service)
    {
        Console.Write("Enter exercise name: ");
        string exercise = Console.ReadLine()!;
        Console.Write("Enter sets: ");
        int sets = int.Parse(Console.ReadLine()!);
        Console.Write("Enter reps: ");
        int reps = int.Parse(Console.ReadLine()!);
        Console.Write("Enter weight (kg): ");
        double weight = double.Parse(Console.ReadLine()!);

        service.LogActivity(new Weightlifting
        {
            Exercise = exercise,
            Sets = sets,
            Reps = reps,
            WeightKg = weight
        });

        Console.WriteLine("Weightlifting workout logged successfully!");
        Console.ReadKey();
    }

    public static void SetCalorieGoal(WorkoutService service)
    {
        Console.Write("Enter daily calorie goal: ");
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