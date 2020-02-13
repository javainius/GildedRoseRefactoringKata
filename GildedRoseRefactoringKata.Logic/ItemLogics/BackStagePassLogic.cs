using GildedRoseRefactoringKata.Logic.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class BackStagePassLogic
    {
        private Item _item { get; set; }
        private QualityCalculator _quality { get; set; }
        private SellInCalculator _sellIn { get; set; }

        public BackStagePassLogic(Item item)
        {
            _item = item;
            _quality = new QualityCalculator(item.Quality);
            _sellIn = new SellInCalculator(item.SellIn);
        }

        public Item GetUpdatedItem()
        {
            _item.SellIn = _sellIn.DecreaseSellInByOne();

            if (_sellIn.SellIn > 5 && _sellIn.SellIn < 11)
            {
                _item.Quality = _quality.IncreaseQualityBy(2);
            }
            else if (_sellIn.SellIn < 6 && _sellIn.SellIn > 0)
            {
                _item.Quality = _quality.IncreaseQualityBy(3);
            }
            else if (_sellIn.IsSellInNegativeOrZero())
            {
                _item.Quality = 0;
            }
            else
            {
                _item.Quality = _quality.IncreaseQualityByOne();
            }

            return _item;
        }
    }
}
