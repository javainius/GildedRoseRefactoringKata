using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRoseRefactoringKata.Tests
{
    class AgedBrieTests
    {
        [Test]
        public void UpdateQuality_Given1DaySellInPositive_QualityIncreasesBy1()
        {
            //Arrange
            int days = 1;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 15, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);


            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(14, Items[0].SellIn);
            Assert.AreEqual(38, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given3DaysSellIn0_QualityIncreasesBy6()
        {
            //Arrange
            int days = 3;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 30 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(-3, Items[0].SellIn);
            Assert.AreEqual(36, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given18DaysQuality3_QualityIsLowerThan50()
        {
            //Arrange
            int days = 18;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Aged Brie", SellIn = 15, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(-3, Items[0].SellIn);
            Assert.AreEqual(50, Items[0].Quality);
        }
    }
}
