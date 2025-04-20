using System;
using System.Linq;

namespace FitnessTrackerGUI.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidateUserName(string username) =>
            !string.IsNullOrWhiteSpace(username) && username.All(char.IsLetterOrDigit);

        public static bool IsPositiveNumber(int value) => value > 0;

        public static bool IsValidPassword(string password) =>
            password.Length == 12 && password.Any(char.IsUpper) && password.Any(char.IsLower);

        public static bool TryParsePositiveInt(string input, out int value)
        {
            if (int.TryParse(input, out value) && value > 0) return true;

            value = 0;
            return false;
        }

        public static bool TryParsePositiveDouble(string input, out double value)
        {
            if (double.TryParse(input, out value) && value > 0) return true;

            value = 0;
            return false;
        }
    }
}
