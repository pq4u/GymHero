using GymHero.Common.Models.Enums;

namespace GymHero.Common.Models;

public class UserGoal
{
    public GoalType Type { get; set; }
    public double TargetValue { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}