using MyWeb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Implementation
{
    public class Multiplication : IOperation
    {
        public double Calculate(double lhsOperand, double rhsOperand) => lhsOperand * rhsOperand;
    }
}
