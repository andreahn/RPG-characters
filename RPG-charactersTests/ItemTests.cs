using System;
using Xunit;
using RPG_characters;
using RPG_characters.Custom_Exceptions;

namespace RPG_charactersTests
{
    public class ItemTests
    {
        #region EquipItem() tests
        [Fact]
        public void EquipItem_WeaponLevelTooHigh_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Weapon testAxe = new Weapon(
            "Common axe",
            2,
            Slot.SLOT_WEAPON,
            WeaponType.WEAPON_AXE,
            new WeaponAttributes(7, 1.1)
            );

            // Act & assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipItem(testAxe));
        }

        [Fact]
        public void EquipItem_ArmourLevelTooHigh_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Armour testPlateBody = new Armour(
            "Common plate body armour",
            2,
            Slot.SLOT_BODY,
            ArmourType.ARMOUR_PLATE,
            new PrimaryAttributes(1, 0, 0)
            );

            // Act & assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipItem(testPlateBody));
        }

        [Fact]
        public void EquipItem_IncompatibleWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Weapon testBow = new Weapon(
            "Common bow",
            1,
            Slot.SLOT_WEAPON,
            WeaponType.WEAPON_BOW,
            new WeaponAttributes(12, 0.8)
            );

            // Act & assert
            Assert.Throws<InvalidWeaponException>(() => testWarrior.EquipItem(testBow));
        }

        [Fact]
        public void EquipItem_IncompatibleArmourType_ShouldThrowInvalidArmorException()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Armour testClothHead = new Armour(
            "Common cloth head amrour",
            1,
            Slot.SLOT_HEAD,
            ArmourType.ARMOUR_CLOTH,
            new PrimaryAttributes(0, 0, 5)
            );

            // Act & assert
            Assert.Throws<InvalidArmorException>(() => testWarrior.EquipItem(testClothHead));
        }

        [Fact]
        public void EquipItem_ValidWeapon_ShouldReturnSuccessMessage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Weapon testAxe = new Weapon(
            "Common axe",
            1,
            Slot.SLOT_WEAPON,
            WeaponType.WEAPON_AXE,
            new WeaponAttributes(7, 1.1)
            );

            string expected = "New weapon equipped!";

            // Act
            string actual = testWarrior.EquipItem(testAxe);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EquipItem_ValidArmour_ShouldReturnSuccessMessage()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Armour testPlateBody = new Armour(
            "Common plate body armour",
            1,
            Slot.SLOT_BODY,
            ArmourType.ARMOUR_PLATE,
            new PrimaryAttributes(1, 0, 0)
            );

            string expected = "New armour equipped!";

            // Act
            string actual = testWarrior.EquipItem(testPlateBody);

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region CharacterDamage() tests

        [Fact]
        public void CharacterDamage_NoWeaponEquipped_ShouldReturnExpectedValue()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");
            double expected = 1 * (1 + (5 / 100));

            // Act
            double actual = testWarrior.CharacterDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CharacterDamage_WeaponEquipped_ShouldReturnExpectedValue()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Weapon testAxe = new Weapon(
            "Common axe",
            1,
            Slot.SLOT_WEAPON,
            WeaponType.WEAPON_AXE,
            new WeaponAttributes(7, 1.1)
            );

            testWarrior.EquipItem(testAxe);
            double expected = (7 * 1.1) * (1 + (5 / 100));

            // Act
            double actual = testWarrior.CharacterDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CharacterDamage_WeaponAndArmourEquipped_ShouldReturnExpectedValue()
        {
            // Arrange
            Warrior testWarrior = new Warrior("");

            Weapon testAxe = new Weapon(
            "Common axe",
            1,
            Slot.SLOT_WEAPON,
            WeaponType.WEAPON_AXE,
            new WeaponAttributes(7, 1.1)
            );

            Armour testPlateBody = new Armour(
            "Common plate body armour",
            1,
            Slot.SLOT_BODY,
            ArmourType.ARMOUR_PLATE,
            new PrimaryAttributes(1, 0, 0)
            );

            testWarrior.EquipItem(testAxe);
            testWarrior.EquipItem(testPlateBody);
            double expected = (7 * 1.1) * (1 + ((5 + 1) / 100));

            // Act
            double actual = testWarrior.CharacterDamage();

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
