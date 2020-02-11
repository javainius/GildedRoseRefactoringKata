using GildedRoseRefactoringKata;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public class ItemTest
    {
        [Test]
        public void Test1()
        {
            //Arrange
            IList<Item> Items = new List<Item> { 
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 }
            };


            // Act
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();


            // Assert
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
        }
    }
}