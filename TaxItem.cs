using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEBusiness
{

    public class TaxItem
    {
        private int maxLimit;
        private int minLimit;
        private double taxRate;
        private double additionCost;
        
        public TaxItem(int minlimit, int maxLimit, double taxRate, double additionCost)
        {
            this.maxLimit = maxLimit;
            this.minLimit = minlimit;
            this.taxRate = taxRate;
            this.additionCost = additionCost;
        }
        public double TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }            
        }
        public double AdditionCost
        {
            get { return additionCost; }
            set { additionCost = value; }
        }        
        public int MaxLimit
        {
            get { return maxLimit; }
            set { maxLimit = value; }
        }
        public int MinLimit
        {
            get { return minLimit; }
            set { minLimit = value; }
        }
    }
}
