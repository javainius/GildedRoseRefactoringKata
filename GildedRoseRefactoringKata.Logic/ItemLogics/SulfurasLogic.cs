using GildedRoseRefactoringKata.Logic.Calculations;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class SulfurasLogic : LogicModel
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
