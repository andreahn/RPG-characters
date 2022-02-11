using System;

namespace RPG_characters
{
    class Weapon : Item
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
        public Weapon() : base()
        {
            // default values
            itemType = WeaponType.WEAPON_STAFF;
            weaponAttributes = new WeaponAttributes();
        }
        public Weapon(string name, int level, Slot slot, WeaponType type) : base(name, level, slot)
        {
            itemType = type;
            weaponAttributes = new WeaponAttributes();
        }

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
