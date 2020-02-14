using GildedRoseRefactoringKata.Logic.Calculations;
using GildedRoseRefactoringKata.Logic.ItemLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public abstract class LogicModel
    {
        protected Item _item { get; set; }
        protected QualityCalculator _quality { get; set; }
        protected SellInCalculator _sellIn { get; set; }
    }
}
