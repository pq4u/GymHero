namespace GymHero.Common.Models;

public class WorkoutSession
{
    public Workout Workout { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }
    public List<Set> CompletedSets { get; set; }
}