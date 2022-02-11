using System;

namespace RPG_characters
{
    class Armour : Item
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
        public Armour() : base()
        {
            itemType = ArmourType.ARMOUR_CLOTH;
            armourAttributes = new PrimaryAttributes();
        }

        public Armour(string name, int level, Slot slot, ArmourType type) : base(name, level, slot)
        {
            itemType = type;
            armourAttributes = new PrimaryAttributes();
        }

        public Armour(string name, int level, Slot slot, ArmourType type, PrimaryAttributes attributes) : base(name, level, slot)
        {
            itemType = type;
            armourAttributes = attributes;
        }
        #endregion

        #region Methods
        //methods here
        #endregion
    }
}
