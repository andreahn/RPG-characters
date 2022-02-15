using System;
using System.Linq;

namespace RPG_characters
{
    public class Mage : Character
    {
        public Mage(string characterName) : base(characterName)
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_CLOTH };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 1, Intelligence = 5, Strength =  1};
            attributes = new PrimaryAttributes() { Dexterity = 1, Intelligence = 8, Strength = 1 };
        }
        
        public override int TotalAttributes()
        {
            int totalAttributes = this.attributes.Intelligence;
            foreach (var armour in equipped.Select(x => x.Value).OfType<Armour>())
            {
                totalAttributes += armour.ArmourAttributes.Intelligence;
            }
            return totalAttributes;
        }
    }
}
