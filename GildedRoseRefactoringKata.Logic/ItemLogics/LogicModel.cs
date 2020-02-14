using GildedRoseRefactoringKata.Logic.Calculations;
using GildedRoseRefactoringKata.Logic.ItemLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class LogicModel
    {
        public Item _item { get; set; }
        public QualityCalculator _quality { get; set; }
        public SellInCalculator _sellIn { get; set; }
    }
}
