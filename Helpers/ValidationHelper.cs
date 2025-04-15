
namespace FitnessTrackerApp.Helpers;

public static class ValidationHelper
{
    public static bool IsValidateUserName(string username) => !string.IsNullOrWhiteSpace(username) && username.All(char.IsLetterOrDigit);

    public static bool IsPositiveNumber(int value) => value > 0;

    public static bool IsValidPassword(string password) => password.Length == 12 && password.Any(char.IsUpper) && password.Any(char.IsLower);

    public static bool TryReadPositiveInt(string prompt, out int value)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out value) && value > 0) return true;

        MenuUI.ShowError("must be a positive number!");
        value = 0;
        return false;
    }

    public static bool TryReadPositiveDouble(string prompt, out double value)
    {
        Console.Write(prompt);
        if (double.TryParse(Console.ReadLine(), out value) && value > 0) return true;

        MenuUI.ShowError("must be a positive number!");
        value = 0;
        return false;
    }
}