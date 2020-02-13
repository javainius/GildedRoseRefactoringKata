using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GildedRoseRefactoringKata.Tests
{
    class MainTest
    {
        [Test]
        public void MainMethod_OriginalValues_ValuesMatchingTextFromFile()
        {
            //Arrange
            string directory = @"C:\Users\Vainius\source\repos\RefactoringTask\GildedRose-Refactoring-Kata\";
            string[] rightText = File.ReadAllLines(Path.Combine(directory, "TestText.txt"));

            // Act
            Program.Main(new string[] {"smth"});

            // Assert
            Assert.AreEqual(rightText[0], Program.Text);
        }
    }
}
