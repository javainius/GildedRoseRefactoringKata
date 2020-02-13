using GildedRoseRefactoringKata.Logic.ItemLogics;
using System.Collections.Generic;

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
                if (Items[i].Name == "Aged Brie")
                {
                    var agedBrie = new AgedBrieLogic(Items[i]);
                    Items[i] = agedBrie.GetUpdatedItem();
                }
                else if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    // Legendary method for legendary item
                }
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    var backStagePass = new BackStagePassLogic(Items[i]);
                    Items[i] = backStagePass.GetUpdatedItem();
                }
                else
                {
                    var norlmalItem = new NormalItemLogic(Items[i]);
                    Items[i] = norlmalItem.GetUpdatedItem();
                }
            }
        }
    }
}
