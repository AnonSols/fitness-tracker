using FitnessTrackerApp.Services;
using FitnessTrackerApp.Helpers;

namespace FitnessTrackerApp.Helpers;

public static class AuthUI
{
    public static void RegisterUser(UserService userService)
    {
        Console.Write("Enter username (letters/numbers only): ");
        string username = Console.ReadLine()!;

        Console.Write("Enter password (12 chars, 1 uppercase, 1 lowercase): ");
        string password = Console.ReadLine()!;



        if (!ValidationHelper.IsValidateUserName(username))
        {
            Console.WriteLine("Username must be alphanumeric.");
            Console.ReadKey();
            return;
        }

        if (!ValidationHelper.IsValidPassword(password))
        {
            Console.WriteLine("Invalid username/password format. Follow the rules: ");
            Console.WriteLine("- Username: Letters/numbers only");
            Console.WriteLine("- Password: 12 chars, 1 uppercase, 1 lowercase");
            Console.ReadKey();
            return;
        }

        if (userService.Register(username, password)) Console.WriteLine("Registration successful!");
        else Console.WriteLine("username already exists.");
    }

    public static bool LoginUser(UserService userService)
    {
        Console.Write("Username: ");
        string username = Console.ReadLine()!;

        Console.Write("Password: ");
        string password = Console.ReadLine()!;

        return userService.Login(username, password);
    }

}