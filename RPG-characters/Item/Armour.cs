using System;

namespace RPG_characters
{
    public class Armour : Item
    {

        #region Variables
        private ArmourType itemType;
        private PrimaryAttributes armourAttributes;
        #endregion

        #region Properties
        public ArmourType ItemType { get => itemType; }
        public PrimaryAttributes ArmourAttributes { get => armourAttributes; }
        #endregion

        #region Constructors

        public Armour(string name, int level, Slot slot, ArmourType type, PrimaryAttributes attributes) : base(name, level, slot)
        {
            itemType = type;
            armourAttributes = attributes;
        }
        #endregion
    }
}
