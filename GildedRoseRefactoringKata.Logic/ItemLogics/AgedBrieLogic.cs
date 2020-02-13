using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.ItemLogics
{
    public class AgedBrieLogic
    {
        public Item AgedBrie { get; set; }
        public AgedBrieLogic(Item agedBrie)
        {
            AgedBrie = agedBrie;
        }

        public Item GetUpdatedItem()
        {
            return AgedBrie;
        }
    }
}
