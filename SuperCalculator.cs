using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEBusiness
{
    public class SuperAnnuationCalculator
    {
        public static long Calculate(double grossIncome, double superAnnuationRate)
        {
            return (Int64)Math.Round(grossIncome * superAnnuationRate);
        }
    }
}