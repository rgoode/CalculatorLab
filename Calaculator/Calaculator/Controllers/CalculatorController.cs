using Calaculator.Models.Calculator;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calaculator.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Calculator(CalculatorViewModel calculatorviewmodel)
        {
            
            switch (calculatorviewmodel.makecalculate)
            {
                case CalculatorViewModel.MakeCalculate.Add:
                    calculatorviewmodel.TotalNumber = calculatorviewmodel.EntryOne + calculatorviewmodel.EntryTwo;
                    break;
                case CalculatorViewModel.MakeCalculate.Multiply:
                    calculatorviewmodel.TotalNumber = calculatorviewmodel.EntryOne * calculatorviewmodel.EntryTwo;
                    break;
                case CalculatorViewModel.MakeCalculate.Subtract:
                    calculatorviewmodel.TotalNumber = calculatorviewmodel.EntryOne - calculatorviewmodel.EntryTwo;
                    break;
                case CalculatorViewModel.MakeCalculate.Divide:
                    calculatorviewmodel.TotalNumber = calculatorviewmodel.EntryOne / calculatorviewmodel.EntryTwo;
                    break;
                default:
                    break;
            }

            return View(calculatorviewmodel);
        }



        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        //private readonly ILogger<CalculatorController> _logger;
        //private readonly Calculator _calculator;

        //public CalculatorController(ILogger<CalculatorController> logger, Calculator calculator)
        //{
        //    _logger = logger;
        //    _calculator = calculator;
        //}
    }
}
    


//Create a Calculator app using MVC and forms

//You will need to display the grand total (default 0)
//You will need two input fields that take in your left operand and your right operand
//you will need four different Operations
//Add "+"
//Subtract "-"
//Multiply "*"
//Divide "/"

//The user should be able to input their left and right number, then also find a way to CHECK which operation they want to execute (Add, Subtract, Multiply, Divide) and pass that into your action

//you only need ONE Action in your CalculatorController that processes this information

//YOU will need to figure out HOW to determine HOW the user selects their Operation (add, subtract, multiply, or divide) I highly encourage searching for check boxes, Selects, etc... 

//you DO NOT need to maintain a "tallying total" in other words, each math operation can be it's on separate result, you don't need to increment or decrement "Total"
