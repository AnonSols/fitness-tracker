public class User
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public int CalorieGoal { get; set; } = 0;
}