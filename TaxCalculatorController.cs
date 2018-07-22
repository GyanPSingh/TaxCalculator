using System;
using Microsoft.AspNetCore.Mvc;
using ACMEBusiness;
using System.IO;
namespace ACME_API.Controllers
{
    [Route("api/[controller]")]
    public class TaxCalculatorController : Controller
    {        
        [HttpGet]
        public IActionResult GeneratePaySlip()
        {
            try
            {
                PaySlipCalculator paySlipCalculator = new PaySlipCalculator();
                string currentDirectory = Directory.GetCurrentDirectory();
                string inputFilePath = System.IO.Path.Combine(currentDirectory, "InputFile", "Input.csv");
                string outFilePath = System.IO.Path.Combine(currentDirectory, "OutputFile", "Output.csv");
                paySlipCalculator.execute(inputFilePath, outFilePath);
                return Ok("Pay slip has been generated.");
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);                 
            }            
        }       
    }
}
