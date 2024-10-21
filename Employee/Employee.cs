using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Employee
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            var pay = 0;

            Console.WriteLine("Enter the hourly rate in Rs. ");
            var rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hours you worked");
            var hours = Convert.ToInt32(Console.ReadLine());

            pay = hours * rate;

            if (hours > 0 && hours <= 40)
            {
                Console.WriteLine($"Total Pay is: {pay}");
            }
            else if (hours > 40)
            {
                var overHours = hours - 40;
                var overPay = pay +  (overHours * rate * 0.5); 
                Console.WriteLine($"Great you worked a lot , your pay is {overPay}");
            }
        }



    }
}
