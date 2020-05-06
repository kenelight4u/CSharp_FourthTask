using Microsoft.AspNetCore.Mvc;

namespace CalculatorWeb.Controllers
{
    public class CalcController : Controller 
    {
        [HttpGet] 
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string firstNumber, string secondNumber)
        {
     
            // for positive Interger
            int numberFirst = int.Parse(firstNumber);
            int numberSecond = int.Parse(secondNumber);

            // Incase its a negative integer
            int negFirst = int.Parse(firstNumber); 
            int negSecond = int.Parse(secondNumber);

            double numberOne = System.Math.Sqrt(numberFirst);
            double numberTwo = System.Math.Sqrt(numberSecond);

            ViewBag.NegFirst = negFirst;
            ViewBag.NegSecond = negSecond;

            ViewBag.NumberFirst = numberFirst;
            ViewBag.NumberSecond = numberSecond;

            ViewBag.NumberTwo = numberTwo;
            ViewBag.NumberOne = numberOne;
            return View();
        }
    }
}