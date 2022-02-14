﻿using System;
using Xunit;

namespace RPG_charactersTests
{
    public class CharacterTests
    {
        [Fact]
        public void Mage_Test1()
        {
            RPG_characters.PrimaryAttributes test = new RPG_characters.PrimaryAttributes();
            RPG_characters.Mage testmage = new RPG_characters.Mage("some name", 2);
            //PrimaryAttributes test = new PrimaryAttributes();
            int expected = 0;
            int real = test.Dexterity;
            Assert.Equal(expected, real);
        }
    }
}
