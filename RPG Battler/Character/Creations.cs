using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public  class Creations
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int TotalHealth { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }


        public class Skill
        {
            public string SkillName { get; set; }
            public int BaseDamage { get; set; }
            public int MaxCooldown { get; private set; }
            public int CurrentCooldown { get; private set; }

            public Skill(string name, int baseDamage, int cooldown)
            {
                SkillName = name;
                BaseDamage = baseDamage;
                MaxCooldown = cooldown;
                CurrentCooldown = 0; // Ready to use at the start
            }

            public void UseSkill(Hero hero)
            {
            }

            public void CooldownTick()
            {
                if (CurrentCooldown > 0)
                {
                    CurrentCooldown--;
                }
            }
        }
        public class Spell
        {
            public string SpellName { get; set; }
            public int ManaCost { get; set; }
            public int BaseDamage { get; set; }

            public Spell(string name, int manaCost, int baseDamage)
            {
                SpellName = name;
                ManaCost = manaCost;
                BaseDamage = baseDamage;
            }

            public int CalculateSpellDamage(int heroPower)
            {
                return BaseDamage + (heroPower / 2);
            }

            public void CastSpell(Hero hero)
            {
            }
        }

    }

    public enum CombatClass
    {
        None,
        Warrior,
        Wizard,
        Rogue
    }
}
