namespace DwarfKiller.Models
{
    public class Hero : Character //This means that Hero inherits from Character
    {
        //Because Hero has a parent of Character, it has access to these commented out properties:
        //public string Name { get; set; }
        //public int HitPoints { get; set; }
        //public int AttackPoints { get; set; }
        //public int DefensePoints { get; set; }
        //Whenever you instantiate a Hero, it is also compatible with Character. Just like a decimal can be turned into an integer.

        public int CombatLevel { get; set; }
        public int KillCount { get; set; }
        public int DeathCount { get; set; }
    }
}