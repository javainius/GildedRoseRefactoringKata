using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.Calculations
{
    public class SellInCalculator
    {
        public int SellIn { get; set; }
        public SellInCalculator(int sellIn)
        {
            SellIn = sellIn;
        }
        public int DecreaseQualityBy(int number)
        {
            for (int i = 0; i < number; i++) SellIn = DecreaseSellInByOne();

            return SellIn;
        }
        public int DecreaseSellInByOne() => SellIn - 1;
        
        public bool IsSellInNegativeOrZero() => SellIn <= 0 ? true : false;
    }
}
