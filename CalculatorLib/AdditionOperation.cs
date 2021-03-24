﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class AdditionOperation : IOperation
    {
        //public string OperatorCode => "+";
        public string OperatorCode
        {
            get { return "+"; }
        }
        public int Apply( int operand1, int operand2 )
        {
            return operand1 + operand2;
        }
    }
}
