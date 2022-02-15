﻿using System;

namespace RPG_characters
{
    public class Mage : Character
    {
        public Mage(string characterName) : base(characterName)
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_CLOTH };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 1, Intelligence = 5, Strength =  1};
            attributes = new PrimaryAttributes() { Dexterity = 1, Intelligence = 8, Strength = 1 };
        }
    }
}
