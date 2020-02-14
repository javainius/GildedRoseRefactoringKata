using GildedRoseRefactoringKata.Logic.Calculations;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class BackStagePassLogic : LogicModel
    {
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
