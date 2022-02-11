using System;

namespace RPG_characters
{
    abstract class Item
    {
        #region Variables
        protected string itemName;
        protected int itemLevel;
        protected Slot itemSlot1;
        #endregion

        #region Properties
        public string ItemName { get { return itemName; } }
        public int ItemLevel { get { return itemLevel; } }
        public Slot ItemSlot { get => itemSlot1; set => itemSlot1 = value; }
        #endregion

        #region Constructors
        //constructor here
        #endregion

        #region Methods
        //methods here
        #endregion
    }
}
