using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACMEBusiness
{
    public class PaySlipCalculator
    {
        public void execute(String inputFile, String outputFile)
        {
            try
            {
                CSVFileReader reader = new CSVFileReader();
                List<Employee> employees = reader.readFromFile(inputFile);
                if (employees != null && employees.Count > 0)
                {
                    foreach (Employee employee in employees)
                    {
                        employee.IncomeTax = CalculateIncomeTax(employee.AnnualSalary);
                        employee.SuperAnnuationAmount = CalculateSuperAnnuation(employee.GrossIncome(), employee.SuperAnnuationRate);
                    }
                    CSVFileWriter writer = new CSVFileWriter();
                    writer.WriteEmployee(employees, outputFile);                   
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long CalculateIncomeTax(int annualSalary)
        {
            return TaxCalculator.Calculate(annualSalary);
        }

        public long CalculateSuperAnnuation(int grossIncome, double superRate)
        {
            return SuperAnnuationCalculator.Calculate(grossIncome, superRate);
        }
    }
}
