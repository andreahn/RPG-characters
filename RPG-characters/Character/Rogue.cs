using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    public class Rogue : Character
    {
        public Rogue(string characterName) : base(characterName)
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_LEATHER, ArmourType.ARMOUR_MAIL };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_DAGGER, WeaponType.WEAPON_SWORD };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 4, Intelligence = 1, Strength =  1};
            attributes = new PrimaryAttributes() { Dexterity = 6, Intelligence = 1, Strength = 2 };
        }

        public override double TotalAttributes()
        {
            // Each point of dexterity increases Rogues damage by 1%
            // Therefore, only take dexterity attributes from character and armour

            double totalAttributes = this.attributes.Dexterity;
            foreach (var armour in equipped.Select(x => x.Value).OfType<Armour>())
            {
                totalAttributes += armour.ArmourAttributes.Dexterity;
            }
            return totalAttributes;
        }
    }
}
