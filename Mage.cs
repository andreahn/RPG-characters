﻿using System;

namespace RPG_characters
{
    class Mage : Character
    {
        public Mage(string characterName, int level) : base(characterName, level)
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_CLOTH };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 1, Intelligence = 5, Strength =  1};
            attributes = new PrimaryAttributes() { Dexterity = 1, Intelligence = 8, Strength = 1 };

            if (level > 1)
            {
                attributes += levelUpAttributeValues * (level - 1);
            }
            //equipment.Add(Slot.SLOT_HEAD, new Armour() { ItemName = "Some item", ItemType = ArmourType.ARMOUR_CLOTH });
        }
        //public override void characterType()
        //{
        //    Console.WriteLine("mage");
        //}

    }
}
