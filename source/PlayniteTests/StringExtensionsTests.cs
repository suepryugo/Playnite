﻿using NUnit.Framework;
using Playnite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayniteTests
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void NormalizeGameNameTest()
        {
            Assert.AreEqual("Command & Conquer Red Alert 3: Uprising: Best: Game",
                StringExtensions.NormalizeGameName("Command®   & Conquer™ Red_Alert 3™ : Uprising©:_Best- Game"));

            Assert.AreEqual("The Witcher 3",
                StringExtensions.NormalizeGameName("Witcher 3, The"));

            Assert.AreEqual("Pokemon Red Test",
                 StringExtensions.NormalizeGameName("Pokemon.Red.[US].[l33th4xor].Test.[22]"));

            Assert.AreEqual("Pokemon Red Test",
     StringExtensions.NormalizeGameName("Pokemon.Red.[US].(l33th 4xor).Test.(22)"));
        }

        [Test]
        public void ConvertToSortableName()
        {
            Assert.AreEqual("Witcher 3", StringExtensions.ConvertToSortableName("The Witcher 3"));
            Assert.AreEqual("Witcher 3", StringExtensions.ConvertToSortableName("the Witcher 3"));
            Assert.AreEqual("Game", StringExtensions.ConvertToSortableName("A Game"));
            Assert.AreEqual("Usual Game", StringExtensions.ConvertToSortableName("An Usual Game"));
            Assert.AreEqual("AnUsual Game", StringExtensions.ConvertToSortableName("AnUsual Game"));
        }
    }
}
