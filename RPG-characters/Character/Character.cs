using RPG_characters.Custom_Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_characters
{
    public abstract class Character
    {
        #region Variables
        // variables go here
        protected ArmourType[] compatibleArmour;
        protected WeaponType[] compatibleWeapons;
        protected string name;
        protected int level;
        protected PrimaryAttributes attributes;
        protected PrimaryAttributes levelUpAttributeValues;
        protected Dictionary<Slot, Item> equipped = new Dictionary<Slot, Item>();
        #endregion

        #region Properties
        public ArmourType[] CompatibleArmour { get => compatibleArmour; }
        public WeaponType[] CompatibleWeapons { get => compatibleWeapons; }
        public string Name { get => name; }
        public PrimaryAttributes Attributes { get => attributes; }
        public PrimaryAttributes LevelUpAttributeValues { get => levelUpAttributeValues; }
        public Dictionary<Slot, Item> Equipped { get => equipped; }

        public int Level { get => level; }


        #endregion

        #region Constructors
        public Character(string characterName)
        {
            this.name = characterName;
            level = 1;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Increases level of character, and updates attributes with its type's level up values.
        /// </summary>
        public void LevelUp()
        {
            attributes += levelUpAttributeValues;
            level++;
        }

        /// <summary>
        /// Attempts to equip item of type armour
        /// </summary>
        /// <param name="ItemToBeEquipped">Armour object to be equipped</param>
        public string EquipItem(Armour ItemToBeEquipped)
        {
            if (ItemToBeEquipped.ItemSlot == Slot.SLOT_WEAPON)
            {
                throw new InvalidArmorException("Armour cannot be equipped in weapon slot.");
            }
            else if (!(compatibleArmour.Contains(ItemToBeEquipped.ItemType))){
                throw new InvalidArmorException("This character type cannot equip this type of armour.");
            }
            else if (ItemToBeEquipped.ItemLevel > level)
            {
                throw new InvalidArmorException("Character level isn't high enough for this armour.");
            }
            else
            {
                equipped[ItemToBeEquipped.ItemSlot] = ItemToBeEquipped;
                return "New armour equipped!";
            }
        }

        /// <summary>
        /// Attempts to equip item of type weapon
        /// </summary>
        /// <param name="ItemToBeEquipped">Weapon object to be equipped</param>
        public string EquipItem(Weapon ItemToBeEquipped)
        {
            if (ItemToBeEquipped.ItemSlot != Slot.SLOT_WEAPON)
            {
                throw new InvalidWeaponException("Weapon cannot be equipped in armour slot.");
            }
            else if (!(compatibleWeapons.Contains(ItemToBeEquipped.ItemType)))
            {
                throw new InvalidWeaponException("This character type cannot equip this type of weapon.");
            }
            else if (ItemToBeEquipped.ItemLevel > level)
            {
                throw new InvalidWeaponException("Character level isn't high enough for this weapon.");
            }
            else
            {
                equipped[ItemToBeEquipped.ItemSlot] = ItemToBeEquipped;
                return "New weapon equipped!";
            }
        }

        /// <summary>
        /// Calculates the attributes total of the character and equipped armour
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
            int totalStrength = this.attributes.Strength;
            int totalIntelligence = this.attributes.Intelligence;
            int totalDexterity = this.attributes.Dexterity;

            foreach (var item in equipped.Select(x => x.Value).OfType<Armour>())
            {
                totalStrength += item.ArmourAttributes.Strength;
                totalIntelligence += item.ArmourAttributes.Intelligence;
                totalDexterity += item.ArmourAttributes.Dexterity;
            }

            StringBuilder stats = new StringBuilder("", 200);
            stats.AppendFormat("----STATS----{0}", Environment.NewLine);
            stats.AppendFormat("Name: {0} (level: {1}){2}", this.name, this.level, Environment.NewLine);
            stats.AppendFormat("Strength: {0}{1}", totalStrength, Environment.NewLine);
            stats.AppendFormat("Intelligence: {0}{1}", totalIntelligence, Environment.NewLine);
            stats.AppendFormat("Dexterity: {0}{1}", totalDexterity, Environment.NewLine);
            stats.AppendFormat("Damage per second: {0}", this.CharacterDamage());
            Console.WriteLine(stats);
        }

        /// <summary>
        /// Calculates total character damage (based on total attributes and weapon attributes)
        /// </summary>
        /// <returns>Character damage</returns>
        public double CharacterDamage()
        {
            var currentWeapon = equipped.Values.OfType<Weapon>().SingleOrDefault();
            double characterDamage = 1 + TotalAttributes()/100;

            if (currentWeapon != null)
                characterDamage *= currentWeapon.DamagePerSecond();
            return characterDamage;
        }
        #endregion
    }
}
