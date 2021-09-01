using Microsoft.AspNetCore.Mvc;
using MyWeb.Implementation;
using MyWeb.Interfaces;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static MyWeb.Models.CalcModel;

namespace MyWeb.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult IndexCalculator()
        {
            return View(new CalcModel());
        }

        [HttpPost]
        public async Task<IActionResult> IndexCalculator(CalcModel model)
        {
            Debug.WriteLine(model.lhsOperand);
            Debug.WriteLine(model.rhsOperand);
            Debug.WriteLine(model.Result);
            ModelState.Clear();
            var operation = GetOperation(model.calculationMethod);
            var calculator = new Calculator(operation);
            model.Result = calculator.Calculate(model.lhsOperand, model.rhsOperand);
            return View(model);
        }
        private IOperation GetOperation(CalculationMethod calcMethod)
    => calcMethod switch
    {
        CalculationMethod.Addition => new Addition(),
        CalculationMethod.Substraction => new Substraction(),
        CalculationMethod.Multiplication => new Multiplication(),
        CalculationMethod.Division => new Division(),
        _ => throw new NotImplementedException($"{nameof(GetOperation)} - CalculationMethod.{calcMethod} was not mapped to an operation!"),
    }; 
    }
}
