
using System.Reflection.PortableExecutable;
using System.ComponentModel.Design;
using System;
using Microsoft.AspNetCore.Mvc;


namespace squareRoot.Controllers
{
        public class SqrController: Controller
        {
            [HttpGet]
            public ActionResult sqr()
            {
                return View();
            }

            [HttpPost]
            public ActionResult sqr(string firstNumber, string secondNumber)
            {
                 
                //Changes Input from String to Integer            
                int number1 = int.Parse(firstNumber);
                int number2 = int.Parse(secondNumber);


                //Stores value of inputted numbers for display
                ViewBag.firstNumber = number1;
                ViewBag.secondNumber = number2;
                
                //Calculates the square of the inputted numbers
                double Result1 = Math.Sqrt(number1);
                double Result2 = Math.Sqrt(number2);

                //Stores Result of the square root of two numbers in two variables
                ViewBag.Result1 = Result1;
                ViewBag.Result2 = Result2;
                ViewBag.Compare = Math.Max(number1, number2);
                
                
                return View();
            }
    }



        



}
