using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Monster : Creations
    {
        public Monster()
        {
            Monster monster = new Monster();
        }

        public enum CreatureRarity
        {
            Common,
            Rare,
            Heroic,
            Legendary
        }

        public int DropExperience { get; set; }
        public CreatureRarity Rarity { get; set; }

        public void PowerLevel(int parameter)
        {
            if (parameter > 10)
            LevelUp();
        }

        public void LevelUp()
        {
            switch (Rarity)
            {
                case CreatureRarity.Common:
                    TotalHealth = new Random().Next(2, 10);
                    TotalPower = new Random().Next(2);
                    TotalLuck = new Random().Next(1, 3);
                    break;
                case CreatureRarity.Rare:
                    TotalHealth = new Random().Next(10, 13);
                    TotalPower = new Random().Next(3, 4);
                    TotalLuck = (new Random()).Next(3, 5);
                    break;
                case CreatureRarity.Heroic:
                    TotalHealth = new Random().Next(12, 20);
                    TotalPower = new Random().Next(3, 5);
                    TotalLuck = new Random().Next(3, 7);
                    break;
                case CreatureRarity.Legendary:
                    TotalHealth = new Random().Next(20, 40);
                    TotalPower = new Random().Next(5, 12);
                    TotalLuck = new Random().Next(10, 20);
                    break;
            }
            static CreatureRarity Idk()
            {
                Random random = new Random();
                double value = random.NextDouble();

                if (value < 0.60)
                    return CreatureRarity.Common;
                else if (value < 0.90)
                    return CreatureRarity.Rare;
                else if (value < 0.99)
                    return CreatureRarity.Heroic;
                else return CreatureRarity.Legendary;
            }
        }
        public Monster(int dropExperience, CreatureRarity rarity)
        {
            
            DropExperience = dropExperience;
            Rarity = rarity;
            Name = "Unknown Beast";
            PowerLevel(new Random().Next(5, 14));
        }
    }
}
