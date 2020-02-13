using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseRefactoringKata.Logic.Calculations
{
    public class QualityChanger
    {
        public int Quality { get; set; }
        public QualityChanger(int quality)
        {
            Quality = quality;
        }
        
        public int DecreaseQualityBy(int number)
        {
            for(int i = 0; i < number; i++) DecreaseQualityByOne();

            return Quality;
        }

        
        public int IncreaseQualityBy(int number)
        {
            for (int i = 0; i < number; i++) IncreaseQualityByOne();

            return Quality;
        }

        public int DecreaseQualityByOne() => Quality <= 0 ? 0 : Quality--;

        public int IncreaseQualityByOne() => Quality >= 50 ? 50 : Quality++;
    }
}
