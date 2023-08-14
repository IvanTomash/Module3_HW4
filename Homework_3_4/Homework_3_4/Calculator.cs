using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_4
{
    public delegate int Calculation(int a, int b);

    internal class Calculator
    {
        public event Calculation Calculate;
        int result = 0;

        public Calculator() 
        {
            Calculate += Add;
            Calculate += Multiply;
            Calculate += Divide;
        }

        private int Add(int a, int b) => a + b; 
        
        private int Multiply(int a, int b) => a * b;

        private int Divide(int a, int b) => a / b;
        
        public void PerformCalculation(int a, int b)
        {
            if (Calculate != null)
            {
                var invocationList = Calculate.GetInvocationList();
                result = 0;
                foreach (var invocation in invocationList)
                {
                    result += ((Calculation)invocation).Invoke(a, b);
                }                
            }            
        }

        public void CheckCalculation(Action<int, int> action, int a, int b)
        {
            try
            {
                action(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception information: {ex.Message}");
            }

            Console.WriteLine($"Calculation result: {result}");
        }
    }
}
