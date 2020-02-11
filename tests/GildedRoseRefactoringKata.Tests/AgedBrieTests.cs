using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseRefactoringKata.Tests
{
    class AgedBrieTests
    {
        [Test]
        public void Test1()
        {
            //Arrange
            int days = 1;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 15, Quality = 37 }
            };


            // Act
            GildedRose app = new GildedRose(Items);

            for (int i = 0; i < days; i++) app.UpdateQuality();



            // Assert
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(19, Items[0].Quality);
        }
    }
}
