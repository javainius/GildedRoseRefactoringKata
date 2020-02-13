using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.Calculations
{
    public class QualityCalculator
    {
        public int Quality { get; set; }
        public QualityCalculator(int quality)
        {
            Quality = quality;
        }
        
        public int DecreaseQualityBy(int number)
        {
            for(int i = 0; i < number; i++) Quality = DecreaseQualityByOne();

            return Quality;
        }

        
        public int IncreaseQualityBy(int number)
        {
            for (int i = 0; i < number; i++) Quality = IncreaseQualityByOne();

            return Quality;
        }

        public int DecreaseQualityByOne() => Quality <= 0 ? 0 : Quality - 1;

        public int IncreaseQualityByOne() => Quality >= 50 ? 50 : Quality + 1;
    }
}
