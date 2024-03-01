using GymHero.Common.Models.Enums;

namespace GymHero.Common.Models;

public class Exercise
{
    public string Name { get; set; }
    public string Description { get; set; }
    public MuscleGroup PrimaryMuscleGroup { get; set; }
    public List<MuscleGroup> SecondaryMuscleGroups { get; set; }
    public List<Set> Sets { get; set; }
}