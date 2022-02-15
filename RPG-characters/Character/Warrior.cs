using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    public class Warrior : Character
    {
        public Warrior(string characterName) : base(characterName)
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_MAIL, ArmourType.ARMOUR_PLATE };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_AXE, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_SWORD };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 2, Intelligence = 1, Strength =  3};
            attributes = new PrimaryAttributes() { Dexterity = 2, Intelligence = 1, Strength = 5 };
        }
    }
}
