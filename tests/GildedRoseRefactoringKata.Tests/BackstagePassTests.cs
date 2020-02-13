using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System.Collections.Generic;


namespace GildedRoseRefactoringKata.Tests
{
    class BackstagePassTests
    {
        [Test]
        public void UpdateQuality_GivenAll8_Quality29()
        {
            //Arrange
            int days = 8;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 8 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(29, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given1DayMoreThanSellIn_Quality0()
        {
            //Arrange
            int days = 8;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 7, Quality = 8 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given2Days9SellIn_QualityIncreasesBy4()
        {
            //Arrange
            int days = 2;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 8 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(7, Items[0].SellIn);
            Assert.AreEqual(12, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given2Days_QualityIncreasesBy2()
        {
            //Arrange
            int days = 2;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 13, Quality = 8 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(11, Items[0].SellIn);
            Assert.AreEqual(10, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_Given3DaysSellIn4_QualityIncreasesBy9()
        {
            //Arrange
            int days = 3;
            IList<Item> Items = new List<Item> {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 8 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(17, Items[0].Quality);
        }

    }
}
