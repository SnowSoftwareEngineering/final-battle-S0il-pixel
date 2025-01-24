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
            Name = "Unknown";
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 1;
            ExperienceRemaining = 1;
            CombatClass = CombatClass.None;
            Items = new List<Item>();
            Skills = new List<Skill>();
            Spells = new List<Spell>();
            Equipment = new List<Equipment>();
        }
        public void DisplayStats(bool parameter = true)
        {
            if (parameter)
            {
                Console.WriteLine(Name, Health, Power, Luck, Mana, ExperienceRemaining);
            }
            else
            {
                Console.WriteLine(Name, Health, Power, Luck, Mana, ExperienceRemaining, CombatClass, Items, Skills, Spells, Equipment);
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

        public void PowerLevel(int power)
        {
            if (power > Level)
            {
                LevelUp();
                Level = power;
            }//it should take an int as a parameter and call the level up method based on the int.
        }

        public void AwakenHero()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(CombatClass));
            CombatClass = (CombatClass)values.GetValue(random.Next(values.Length));
            PowerLevel(random.Next(8, 13));
            DisplayStats();
            //Assign the hero a random CombatClass. Using PowerLevel, randomly level up the hero to a level between 8 and 12. You will want to implement DisplayStats() to view the hero information.
        }
        public void CalculateTotals()
        {
            //What is this for? Am I missing a step with this?
        }
    }
}
