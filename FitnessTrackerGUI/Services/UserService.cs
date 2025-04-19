namespace FitnessTrackerGUI.Services;
using System.Collections.Generic;

public static class UserService
{
    // Simulated in-memory store: like a mini database in RAM
    private static Dictionary<string, string> _users = new()
    {
        { "solomon", "Solomon123!" },
        { "omolara", "Password123!" }
    };

    public static bool Authenticate(string username, string password)
    {
        return _users.TryGetValue(username, out var storedPassword)
            && storedPassword == password;
    }

    public static void Register(string username, string password)
    {
        if (!_users.ContainsKey(username))
            _users.Add(username, password);
    }

    public static bool UserExists(string username) => _users.ContainsKey(username);
}
