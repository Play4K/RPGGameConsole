using RPGGameConsole.Items.Interfaces;

namespace RPGGameConsole.Entities.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Abilities Abilities { get; set; }
        public int Gold { get; set; }
        public string Background { get; set; }
        public int InventoryWeight { get; set; }
        public List<string> AdventuresPlayed { get; set; }
        public bool isAlive { get; set; }
        public int ArmorClass { get; set; }
        public List<IItem> Inventory { get; set; }
        public int HitPoints { get; set; }

    }

    public class Abilities
    {
        public int Strength { get; set; }
        public int Dexerity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

    }
}
