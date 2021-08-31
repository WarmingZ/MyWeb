using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class CalcModel  
    {
        [DisplayName("First number")]
        public double lhsOperand { get; set; }
        [DisplayName("Second number")]
        public double rhsOperand { set; get; }
        public double Result { get; set; }

        public CalculationMethod calculationMethod { get; set; }
        public enum CalculationMethod
        {
            Addition = '+',
            Substraction = '-',
            Multiplication ='*',
            Division = '/'
        }
    }
}
