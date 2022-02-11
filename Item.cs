using System;

namespace RPG_characters
{
    abstract class Item
    {
        #region Variables
        protected string itemName;
        protected int itemLevel;
        protected Slot itemSlot;
        #endregion

        #region Properties
        public string ItemName { get { return itemName; } }
        public int ItemLevel { get { return itemLevel; } }
        public Slot ItemSlot { get => itemSlot; set => itemSlot = value; }
        #endregion

        #region Constructor
        public Item()
        {
            // default item values
            itemLevel = 1;
            itemName = "Not named";
            itemSlot = Slot.SLOT_HEAD;
        }
        public Item(string name, int level, Slot slot)
        {
            itemLevel = level;
            itemName = name;
            itemSlot = slot;
        }

        #endregion

        #region Methods
        //methods here
        #endregion
    }
}
