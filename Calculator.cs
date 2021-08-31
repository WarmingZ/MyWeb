using MyWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb
{
    public class Calculator
    {
        private IOperation calculator;

        public Calculator (IOperation operation)
        {
            calculator = operation;
        }

        public double Calculate (double lhsOperand, double rhsOperand)
        {
            return calculator.Calculate(lhsOperand, rhsOperand);
        }
    }
}
