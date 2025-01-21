using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Hero Newhero = new Hero();
        }
        public void DisplayStats(bool parameter)
        {
            if (parameter = true)
            {
                Console.WriteLine();
            }
        }

        public void LevelUp()
        {
            switch (CombatClass)
            {
                case CombatClass.Wizard:
                    Health = new Random().Next(1,15);
                    Power = new Random().Next(3,5);
                    Luck = new Random().Next(1,3);
                    break;
                case CombatClass.Warrior:
                    Health = new Random().Next(10,20);
                    Power = new Random().Next(1,3);   
                    Luck = (new Random()).Next(1,3);
                    break;
                case CombatClass.Rogue:
                    Health = new Random().Next(1,15);
                    Power = new Random().Next(1,3);
                    Luck = new Random().Next(3,5);
                    break;
                case CombatClass.None:
                    break;
            }
        }

        public void CalculateTotals()
        {
        }
    }
}
