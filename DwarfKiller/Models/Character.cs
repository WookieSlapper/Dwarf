namespace DwarfKiller.Models
{
    /// <summary>
    /// A character should be inherited from by both heros and enemies.
    /// </summary>
    public class Character
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int AttackPoints { get; set; }
        public int DefensePoints { get; set; }
    }
}