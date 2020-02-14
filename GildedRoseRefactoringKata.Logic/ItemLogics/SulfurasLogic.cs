using GildedRoseRefactoringKata.Logic.Calculations;
using GildedRoseRefactoringKata.Logic.Interfaces;
using GildedRoseRefactoringKata.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class SulfurasLogic : LogicModel, IItemLogic
    {
        public SulfurasLogic(Item item)
        {
            _item = item;
            _quality = new QualityCalculator(item.Quality);
            _sellIn = new SellInCalculator(item.SellIn);
        }

        public Item GetUpdatedItem()
        {
            return _item;
        }
    }
}
