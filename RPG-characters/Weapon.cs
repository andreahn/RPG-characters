using System;

namespace RPG_characters
{
    public class Weapon : Item
    {

        #region Variables
        private WeaponType itemType;
        private WeaponAttributes weaponAttributes;
        #endregion

        #region Properties
        public WeaponType ItemType { get => itemType; }
        public WeaponAttributes WeaponAttributes { get => weaponAttributes; }
        #endregion

        #region Constructor

        public Weapon(string name, int level, Slot slot, WeaponType type, WeaponAttributes attributes) : base(name, level, slot)
        {
            itemType = type;
            weaponAttributes = attributes;
        }
        #endregion

        #region Methods
        public double DamagePerSecond()
        {
            return weaponAttributes.AttackSpeed * weaponAttributes.Damage;
        }
        #endregion
    }
}
