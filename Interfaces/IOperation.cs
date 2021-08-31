using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Interfaces

{
  public  interface IOperation
    {
        double Calculate(double lhsOperand, double rhsOperand);
    }
}
