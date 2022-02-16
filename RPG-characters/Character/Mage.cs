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
        
        public override double TotalAttributes()
        {
            // Each point of intelligence increases Mages damage by 1%
            // Therefore, only take intelligence attributes from character and armour

            double totalAttributes = this.attributes.Intelligence;
            foreach (var armour in equipped.Select(x => x.Value).OfType<Armour>())
            {
                totalAttributes += armour.ArmourAttributes.Intelligence;
            }
            return totalAttributes;
        }
    }
}
