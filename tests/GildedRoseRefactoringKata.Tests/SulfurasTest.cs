using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System.Collections.Generic;


namespace GildedRoseRefactoringKata.Tests
{
    class SulfurasTest
    {
        [Test]
        public void UpdateQuality_Given5Days_ValuesShouldNotChange()
        {
            //Arrange
            int days = 5;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 15, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(15, Items[0].SellIn);
            Assert.AreEqual(37, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given50DaysSellIn0_ValuesShouldNotChange()
        {
            //Arrange
            int days = 50;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 5 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(5, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_GivenAll8_ValuesShouldNotChange()
        {
            //Arrange
            int days = 8;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 8, Quality = 8 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(8, Items[0].SellIn);
            Assert.AreEqual(8, Items[0].Quality);
        }
    }
}
