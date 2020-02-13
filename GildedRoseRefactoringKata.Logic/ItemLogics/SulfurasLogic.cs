using GildedRoseRefactoringKata.Logic.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class SulfurasLogic
    {
        private Item _item { get; set; }
        private QualityCalculator _quality { get; set; }
        private SellInCalculator _sellIn { get; set; }

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
