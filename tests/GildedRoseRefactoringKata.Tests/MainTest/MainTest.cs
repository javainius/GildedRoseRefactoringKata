using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GildedRoseRefactoringKata.Tests.MainTest
{
    class MainTest
    {
        [Test]
        public void MainMethod_OriginalValues_ValuesMatchingTextFromFile()
        {
            //Arrange
            string fileName = "TestText.txt";
            string path = Path.Combine(Environment.CurrentDirectory, @"MainTest\", fileName);
            string rightText = File.ReadAllText(path);

            // Act
            Program.Main(new string[] {"smth"});

            // Assert
            Assert.AreEqual(rightText, Program.Text);
        }
    }
}
