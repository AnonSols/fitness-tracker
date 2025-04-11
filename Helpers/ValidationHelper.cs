namespace FitnessTrackerApp.Helpers;

public static class ValidationHelper
{
    public static bool IsValidateUserName(string username) => !string.IsNullOrWhiteSpace(username) && username.All(char.IsLetterOrDigit);

    public static bool IsPositiveNumber(int value) => value > 0;

    public static bool IsValidPassword(string password) => password.Length == 12 && password.Any(char.IsUpper) && password.Any(char.IsLower);
}