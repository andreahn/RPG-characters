using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG_characters
{
    abstract class Character
    {
        #region Variables
        // variables go here
        protected ArmourType[] compatibleArmour;
        protected WeaponType[] compatibleWeapons;
        protected string name;
        protected PrimaryAttributes attributes;
        protected PrimaryAttributes levelUpAttributeValues;
        protected Dictionary<Slot, Item> equipped = new Dictionary<Slot, Item>()
        {
            { Slot.SLOT_HEAD, new Armour() },
            { Slot.SLOT_BODY, new Armour() },
            { Slot.SLOT_LEGS, new Armour() },
            { Slot.SLOT_WEAPON, new Weapon() }
        };
        #endregion

        #region Properties
        public ArmourType[] CompatibleArmour { get => compatibleArmour; }
        public WeaponType[] CompatibleWeapons { get => compatibleWeapons; }
        public string Name { get => name; }
        public PrimaryAttributes Attributes { get => attributes; }
        public PrimaryAttributes LevelUpAttributeValues { get => levelUpAttributeValues; }
        public Dictionary<Slot, Item> Equipped { get => equipped; }


        #endregion

        #region Constructors
        // constructors go here
        #endregion

        #region Methods
        /// <summary>
        /// Levels up the character with its type's respective level up values
        /// </summary>
        public void LevelUp()
        {
            attributes += levelUpAttributeValues;
        }

        /// <summary>
        /// Attempts to equip item of type armour
        /// </summary>
        /// <param name="ItemToBeEquipped">Armour object to be equipped</param>
        public void EquipItem(Armour ItemToBeEquipped)
        {
            if (ItemToBeEquipped.ItemSlot == Slot.SLOT_WEAPON || !(compatibleArmour.Contains(ItemToBeEquipped.ItemType)))
            {
                // throw exception
                Console.WriteLine("can't do that");
                return;
            }
            Console.WriteLine("can do that");
        }

        /// <summary>
        /// Attempts to equip item of type weapon
        /// </summary>
        /// <param name="ItemToBeEquipped">Weapon object to be equipped</param>
        public void EquipItem(Weapon ItemToBeEquipped)
        {
            if (ItemToBeEquipped.ItemSlot != Slot.SLOT_WEAPON || !(compatibleWeapons.Contains(ItemToBeEquipped.ItemType)))
            {
                // throw exception
                Console.WriteLine("can't do that");
                return;
            }
            Console.WriteLine("can do that");
        }

        /// <summary>
        /// Calculates the total of attributes of the character and equipped armour
        /// </summary>
        /// <returns>Sum of attribute values</returns>
        public int TotalAttributes()
        {
            PrimaryAttributes totalAttributes = this.attributes;
            foreach (var armour in equipped.Select(x => x.Value).OfType<Armour>())
            {
                totalAttributes += armour.ArmourAttributes;
            }

            return totalAttributes.Dexterity + totalAttributes.Intelligence + totalAttributes.Strength;
        }

        /// <summary>
        /// Prints character status summary to console
        /// </summary>
        public void Stats()
        {
            Console.WriteLine($"Strength: {this.attributes.Strength}");
            Console.WriteLine($"Intelligence: {this.attributes.Intelligence}");
            Console.WriteLine($"Dexterity: {this.attributes.Dexterity}");
        }

        //public abstract void damagePerSecond();

        #endregion
    }
}
