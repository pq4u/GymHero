namespace GymHero.Common.Models;

public class Workout
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Exercise> Exercises { get; set; }
}