using Calculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Utility
    {
        public static string OperationSymbol(Operations? op)
        {
            switch (op)
            {
                case Operations.Addition:
                    return "+";
                case Operations.Substraction:
                    return "-";
                case Operations.Multiplication:
                    return "*";
                case Operations.Division:
                    return "/";
                default:
                    return "";
            }
        }
    }
}
