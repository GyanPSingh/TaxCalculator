using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEBusiness
{
    public class TaxCalculator
    {
        private static List<TaxItem> initializeTaxItems()
        {
            List<TaxItem> taxItems = new List<TaxItem>();
            TaxItem itemZero = new TaxItem(0, 18200, 0, 0);
            TaxItem itemOne = new TaxItem(18201, 37000, 0.19, 0);
            TaxItem itemTwo = new TaxItem(37001, 80000, 0.325, 3572);
            TaxItem itemThree = new TaxItem(80001, 180000, 0.37, 19822);
            TaxItem itemFour = new TaxItem(180001, int.MaxValue, 0.45, 54232);
            taxItems.Add(itemZero);
            taxItems.Add(itemOne);
            taxItems.Add(itemTwo);
            taxItems.Add(itemThree);
            taxItems.Add(itemFour);
            return taxItems;
        }
        public static long Calculate(int annualSalary)
        {
            long cal = 0;
            if (annualSalary > 0)
            {
                foreach (TaxItem item in initializeTaxItems())
                {
                    if (annualSalary > item.MinLimit && annualSalary <= item.MaxLimit)
                    {
                        cal = Convert.ToInt32((item.AdditionCost + (annualSalary - item.MinLimit) * item.TaxRate) / 12);
                    }
                }
            }
            return cal;
        }
    }
}