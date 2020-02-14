using GildedRoseRefactoringKata.Logic.Calculations;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class NormalItemLogic : LogicModel
    {
        public NormalItemLogic(Item item)
        {
            _item = item;
            _quality = new QualityCalculator(item.Quality);
            _sellIn = new SellInCalculator(item.SellIn);
        }

        public Item GetUpdatedItem()
        {
            _item.SellIn = _sellIn.DecreaseSellInByOne();
            _item.Quality = _sellIn.IsSellInNegativeOrZero() ? _quality.DecreaseQualityBy(2) : _quality.DecreaseQualityByOne();
            
            return _item;
        }
    }
}
