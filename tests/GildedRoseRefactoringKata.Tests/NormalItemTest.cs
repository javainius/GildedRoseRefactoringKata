using GildedRoseRefactoringKata.Logic.ItemLogics;
using GildedRoseRefactoringKata.Logic.UpdateLogic;
using NUnit.Framework;
using System.Collections.Generic;


namespace GildedRoseRefactoringKata.Tests
{
    class NormalItemTest
    {
        [Test]
        public void UpdateQuality_Given1Day_ValuesChangeBy1()
        {
            //Arrange
            int days = 1;
            IList<Item> Items = new List<Item> {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 15, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(9, Items[0].SellIn);
            Assert.AreEqual(19, Items[0].Quality);

            Assert.AreEqual("Elixir of the Mongoose", Items[1].Name);
            Assert.AreEqual(14, Items[1].SellIn);
            Assert.AreEqual(36, Items[1].Quality);
        }

        [Test]
        public void UpdateQuality_Given10Days_ValuesChangeNormaly()
        {
            //Arrange
            int days = 10;
            IList<Item> Items = new List<Item> {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 15, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(10, Items[0].Quality);

            Assert.AreEqual("Elixir of the Mongoose", Items[1].Name);
            Assert.AreEqual(5, Items[1].SellIn);
            Assert.AreEqual(27, Items[1].Quality);
        }

        [Test]
        public void UpdateQuality_Given40Days_SellInNegativeQuality0()
        {
            //Arrange
            int days = 40;
            IList<Item> Items = new List<Item> {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 15, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(-30, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);

            Assert.AreEqual("Elixir of the Mongoose", Items[1].Name);
            Assert.AreEqual(-25, Items[1].SellIn);
            Assert.AreEqual(0, Items[1].Quality);
        }

        [Test]
        public void UpdateQuality_Given40Days_SellInNegative()
        {
            //Arrange
            int days = 12;
            IList<Item> Items = new List<Item> {
                new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 11, Quality = 37 }
            };
            GildedRose app = new GildedRose(Items);

            // Act


            for (int i = 0; i < days; i++) app.UpdateItems();



            // Assert
            Assert.AreEqual("+5 Dexterity Vest", Items[0].Name);
            Assert.AreEqual(-2, Items[0].SellIn);
            Assert.AreEqual(6, Items[0].Quality);

            Assert.AreEqual("Elixir of the Mongoose", Items[1].Name);
            Assert.AreEqual(-1, Items[1].SellIn);
            Assert.AreEqual(24, Items[1].Quality);
        }
    }
}
