using GymHero.Common.Models.Enums;

namespace GymHero.Common.Models;

public class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public List<WorkoutSession> WorkoutSessions { get; set; }
    public List<UserGoal> Goals { get; set; }
    public List<Measurement> Measurements { get; set; }
    public List<UserRole> Roles { get; set; }
}