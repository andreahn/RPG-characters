using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    public class PrimaryAttributes
    {

        #region Variables
        private int strength;
        private int dexterity;
        private int intelligence;
        #endregion

        #region Properties
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        #endregion

        #region Constructors
        public PrimaryAttributes()
        {
            Strength = 0;
            Dexterity = 0;
            Intelligence = 0;
        }

        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }
        #endregion


        #region Methods
        public static PrimaryAttributes operator+ (PrimaryAttributes Attributes, PrimaryAttributes AttributeUpdateValues)
        {
            Attributes.Strength += AttributeUpdateValues.Strength;
            Attributes.Dexterity += AttributeUpdateValues.Dexterity;
            Attributes.Intelligence += AttributeUpdateValues.Intelligence;
            return Attributes;
        }
        #endregion
    }
}
