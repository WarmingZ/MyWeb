using MyWeb.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Implementation
{
    public class Division : IOperation
    {
        public double Calculate(double lhsOperand, double rhsOperand)
        {
            try
            {
                return lhsOperand / rhsOperand;
            }
            catch (DivideByZeroException ex)
            {
                return 0;
            }
        }
    }
}
