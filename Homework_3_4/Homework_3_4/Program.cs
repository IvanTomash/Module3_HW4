using System;

namespace Homework_3_4
{
    internal sealed class Program
    {
        public static void Main(string[] args) 
        {
            Calculator calculator = new Calculator();
            calculator.CheckCalculation(calculator.PerformCalculation, 10, 5);
        }
    }
}
