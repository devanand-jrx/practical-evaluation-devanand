using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task7
{
    public class Debugging
    {
        public class Calculator
        {
            public int Divide(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Divider cannot be zero.");
                    return 0;
                }

                return a / b;
            }

            public void ProcessNumbers(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    var result = Divide(numbers[i], 2);
                    Console.WriteLine("Result: " + result);
                }
            }
        }
    }
}
//        static void Main(string[] args)
//        {
//            var processor = new Calculator();
//            int[] numbers = { 10, 20, 30, 40, 50 };
//            processor.ProcessNumbers(numbers);
//        }
//    }
//}
