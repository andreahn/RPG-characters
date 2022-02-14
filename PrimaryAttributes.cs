using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    class PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public PrimaryAttributes()
        {
            Strength = 0;
            Dexterity = 0;
            Intelligence = 0;
        }

        public static PrimaryAttributes operator+ (PrimaryAttributes Attributes, PrimaryAttributes AttributeUpdateValues)
        {
            Attributes.Strength += AttributeUpdateValues.Strength;
            Attributes.Dexterity += AttributeUpdateValues.Dexterity;
            Attributes.Intelligence += AttributeUpdateValues.Intelligence;
            return Attributes;
        }

        public static PrimaryAttributes operator* (PrimaryAttributes Attributes, int level)
        {
            Attributes.Strength *= level;
            Attributes.Dexterity *= level;
            Attributes.Intelligence *= level;
            return Attributes;
        }


    }
}
