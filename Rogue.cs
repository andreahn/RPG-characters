using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    class Rogue : Character
    {
        public Rogue(string characterName, int level) : base(characterName, level)
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_LEATHER, ArmourType.ARMOUR_MAIL };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_DAGGER, WeaponType.WEAPON_SWORD };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 4, Intelligence = 1, Strength =  1};
            attributes = new PrimaryAttributes() { Dexterity = 6, Intelligence = 1, Strength = 2 };

            if (level > 1)
            {
                attributes += levelUpAttributeValues * (level - 1);
            }
        }
        //public override void characterType()
        //{
        //    Console.WriteLine("rogue");
        //}
    }
}
