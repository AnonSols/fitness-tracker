using FitnessTrackerApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FitnessTrackerApp.Services;

public class UserService
{
    private readonly List<User> _users = new();

    public bool Register(string username, string password)
    {
        if (!username.All(char.IsLetterOrDigit)) return false;

        if (password.Length != 12 || !password.Any(char.IsUpper) ||
        !password.Any(char.IsLower)) return false;

        _users.Add(new User { Username = username, Password = password });
        return true;
    }

    public bool Login(string username, string password)
    {
        var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        return user != null;
    }
}