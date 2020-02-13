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

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == "Aged Brie")
                {
                    var agedBrie = new AgedBrieLogic(Items[i]);
                    Items[i] = agedBrie.GetUpdatedItem();
                }
                if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    var sulfuras = new SulfurasLogic(Items[i]);
                    Items[i] = sulfuras.GetUpdatedItem();
                }
                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    var backStagePass = new BackStagePassLogic(Items[i]);
                    Items[i] = backStagePass.GetUpdatedItem();
                }
                if (Items[i].Name == "+5 Dexterity Vest")
                {
                    var norlmalItem = new NormalItemLogic(Items[i]);
                    Items[i] = norlmalItem.GetUpdatedItem();
                }
                if (Items[i].Name == "Elixir of the Mongoose")
                {
                    var norlmalItem = new NormalItemLogic(Items[i]);
                    Items[i] = norlmalItem.GetUpdatedItem();
                }




                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
