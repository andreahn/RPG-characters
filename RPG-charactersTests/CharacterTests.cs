using System;
using Xunit;
using RPG_characters;

namespace RPG_charactersTests
{
    public class CharacterTests
    {
        #region Basic character tests
        [Fact]
        public void Character_OnCreation_IsLevelOne()
        {
            // Arrange
            Mage testCharacter = new Mage("");
            int expected = 1;

            // Act
            int actual = testCharacter.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_OnLevelUp_IsLevelTwo()
        {
            // Arrange
            Mage testCharacter = new Mage("");
            int expected = 2;

            // Act
            testCharacter.LevelUp();
            int actual = testCharacter.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Check if child classes have default attributes tests
        [Fact]
        public void Mage_OnCreation_HasDefaultAttributes()
        {
            // Arrange
            Mage testCharacter = new Mage("");
            int[] expected = new int[] {1, 1, 8};

            // Act
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Ranger_OnCreation_HasDefaultAttributes()
        {
            // Arrange
            Ranger testCharacter = new Ranger("");
            int[] expected = new int[] { 1, 7, 1 };

            // Act
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Rogue_OnCreation_HasDefaultAttributes()
        {
            // Arrange
            Rogue testCharacter = new Rogue("");
            int[] expected = new int[] { 2, 6, 1 };

            // Act
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Warrior_OnCreation_HasDefaultAttributes()
        {
            // Arrange
            Warrior testCharacter = new Warrior("");
            int[] expected = new int[] { 5, 2, 1 };

            // Act
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion

        #region Check if child classes have expected attributes on level up tests

        [Fact]
        public void Mage_OnLevelUp_HasExpectedAttributes()
        {
            // Arrange
            Mage testCharacter = new Mage("");
            int[] expected = new int[] { 2, 2, 13 };

            // Act
            testCharacter.LevelUp();
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Ranger_OnLevelUp_HasExpectedAttributes()
        {
            // Arrange
            Ranger testCharacter = new Ranger("");
            int[] expected = new int[] { 2, 12, 2 };

            // Act
            testCharacter.LevelUp();
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Rogue_OnLevelUp_HasExpectedAttributes()
        {
            // Arrange
            Rogue testCharacter = new Rogue("");
            int[] expected = new int[] { 3, 10, 2 };

            // Act
            testCharacter.LevelUp();
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Warrior_OnLevelUp_HasExpectedAttributes()
        {
            // Arrange
            Warrior testCharacter = new Warrior("");
            int[] expected = new int[] { 8, 4, 2 };

            // Act
            testCharacter.LevelUp();
            int[] actual = new int[] {
                testCharacter.Attributes.Strength,
                testCharacter.Attributes.Dexterity,
                testCharacter.Attributes.Intelligence
            };

            // Assert
            Assert.Equal(expected, actual);
        }

        #endregion
    }
}
