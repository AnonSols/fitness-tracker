
using FitnessTrackerApp.Services;
using FitnessTrackerApp.Helpers;

var userService = new UserService();
var workoutService = new WorkoutService();

while (true)
{
    Console.Clear();
    MenuUI.ShowMainMenu();
    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            AuthUI.RegisterUser(userService);
            break;
        case "2":
            if (AuthUI.LoginUser(userService))
            {
                WorkoutUI.WorkoutMenu(workoutService);
            }
            break;
        case "3":
            Environment.Exit(0);
            break;

    }
}
