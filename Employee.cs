using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEBusiness
{
    public class Employee
    {
        private String firstName;
        private String lastName;
        private int annualSalary;
        private double superAnnuationRate;
        private String payPeriod;
        private long incomeTax;
        private long superAnnuationAmount;

        public Employee()
        {

        }

        public Employee(String firstName, String lastName, int annualSalary, double superRate, String paymentStartDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.annualSalary = annualSalary;
            this.superAnnuationRate = superRate;
            this.payPeriod = paymentStartDate;
        }

        protected string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        protected string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Name
        {
            get { return firstName + " " + lastName; }
        }

        protected internal int AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }

        public double SuperAnnuationRate
        {
            get { return superAnnuationRate; }
            set { superAnnuationRate = value; }
        }

        public String PayPeriod
        {
            get { return payPeriod; }
            set { payPeriod = value; }
        }
        public long IncomeTax
        {
            get { return incomeTax; }
            set { incomeTax = value; }
        }
        public long SuperAnnuationAmount
        {
            get { return superAnnuationAmount; }
            set { superAnnuationAmount = value; }
        }

        public int GrossIncome()
        {
            int grossIncome = 0;
            if (AnnualSalary > HardCodedValue.AnnualSalary)
            {
                grossIncome = AnnualSalary / 12;
            }
            return grossIncome;
        }

        public long NetIncome
        {
            get { return GrossIncome() - incomeTax; }

        }

        public static Employee FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Employee employee = new Employee();
            employee.FirstName = Convert.ToString(values[0]);
            employee.LastName = Convert.ToString(values[1]);
            employee.AnnualSalary = Convert.ToInt32(values[2]);
            employee.SuperAnnuationRate = convertToPercentage(Convert.ToString(values[3]));
            employee.PayPeriod = Convert.ToString(values[4]);
            return employee;
        }
        public static double convertToPercentage(String value)
        {
            if (!value.EndsWith("%"))
            {
                Console.WriteLine("value must ends with %");
            }
            return Double.Parse(value.Substring(0, value.Length - 1)) / 100;
        }
    }
}
