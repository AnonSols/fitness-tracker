using FitnessTrackerApp.Services;
using FitnessTrackerApp.Helpers;

var workoutService = new WorkoutService();
var userService = new UserService();
while (true)
{
    Console.Clear();
    Console.WriteLine("Welcome to the Fitness Tracker App! \n");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");
    Console.Write("Please select an option (1-3): ");

    var userChoice = Console.ReadLine()!;

    switch (userChoice)
    {
        case "1":
            ConsoleUIHelper.RegisterUser(userService);
            break;
        case "2":
            ConsoleUIHelper.LoginUser(userService, workoutService);
            break;
        case "3":
            Console.WriteLine("Exiting the application. Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid option.");
            Console.ReadKey();
            break;

    }
}