using FitnessTrackerApp.Services;
using FitnessTrackerApp.Helpers;

var workoutService = new WorkoutService();
var userService = new UserService();
while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to the Fitness Tracker App! \n");
    Console.WriteLine("1. Add a workout");
    Console.WriteLine("2. View all workouts");
    Console.WriteLine("3. Exit");
    Console.Write("Please select an option (1-3): ");

    var userChoice = Console.ReadLine()!;

    switch (userChoice)
    {
        case "1":
            ConsoleUIHelper.RegisterUser(userService);

    }
}