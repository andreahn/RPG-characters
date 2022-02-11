﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_characters
{
    internal class Ranger : Character
    {
        public Ranger()
        {
            compatibleArmour = new ArmourType[] { ArmourType.ARMOUR_LEATHER, ArmourType.ARMOUR_MAIL };
            compatibleWeapons = new WeaponType[] { WeaponType.WEAPON_BOW };
            levelUpAttributeValues = new PrimaryAttributes() { Dexterity = 5, Intelligence = 1, Strength =  1};
            attributes = new PrimaryAttributes() { Dexterity = 7, Intelligence = 1, Strength = 1 };
        }
        //public override void characterType()
        //{
        //    Console.WriteLine("ranger");
        //}
    }
}
