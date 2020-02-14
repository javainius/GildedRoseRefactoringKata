using GildedRoseRefactoringKata.Logic.ItemLogics;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseRefactoringKata.Logic.UpdateLogic
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateItems()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                {
                    case "Aged Brie":
                        var agedBrie = new AgedBrieLogic(Items[i]);
                        Items[i] = agedBrie.GetUpdatedItem();
                        break;

                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    // Legendary method for legendary item

                    case "Backstage passes to a TAFKAL80ETC concert":
                        var backStagePass = new BackStagePassLogic(Items[i]);
                        Items[i] = backStagePass.GetUpdatedItem();
                        break;

                    default:
                        var norlmalItem = new NormalItemLogic(Items[i]);
                        Items[i] = norlmalItem.GetUpdatedItem();
                        break;
                }

            }
        }
        public void UpdateItemsUsingLinq()
        {
            Items.Where(item => item.Name.Equals("Aged Brie")).ToList().ForEach(item => new AgedBrieLogic(item).GetUpdatedItem());

            Items.Where(item => item.Name.Equals("Backstage passes to a TAFKAL80ETC concert")).ToList().ForEach(item => new BackStagePassLogic(item).GetUpdatedItem());

            Items.Where(item => item.Name.Equals("+5 Dexterity Vest")).ToList().ForEach(item => new NormalItemLogic(item).GetUpdatedItem());

            Items.Where(item => item.Name.Equals("Elixir of the Mongoose")).ToList().ForEach(item => new NormalItemLogic(item).GetUpdatedItem());
        }
    }
}
