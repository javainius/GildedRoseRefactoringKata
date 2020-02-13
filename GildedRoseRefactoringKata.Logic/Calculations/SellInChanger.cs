using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.Calculations
{
    public class SellInChanger
    {
        public int SellIn { get; set; }
        public SellInChanger(int sellIn)
        {
            SellIn = sellIn;
        }
        public int DecreaseQualityBy(int number)
        {
            for (int i = 0; i < number; i++) DecreaseSellInByOne();

            return SellIn;
        }
        public int DecreaseSellInByOne() => SellIn--;
        public bool IsSellInNegative() => SellIn < 0 ? true : false;
    }
}
