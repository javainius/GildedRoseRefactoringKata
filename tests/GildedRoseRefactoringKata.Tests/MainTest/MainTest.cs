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
            TextReader tr = new StreamReader(@"TestText.txt");
            string rightText = tr.ReadLine();

            // Act
            Program.Main(new string[] {"smth"});

            // Assert
            Assert.AreEqual(rightText, Program.Text);
        }
    }
}
