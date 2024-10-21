using System;

namespace PracticalEvaluationDevanand.Task1
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            var grosspay = 0;

            Console.WriteLine("Enter the hourly rate in Rs. ");
            bool isRate = int.TryParse(Console.ReadLine(), out var rate);
            if (!isRate)
            {
                Console.WriteLine("not a valid rate");
            }
            Console.WriteLine("Enter the hours you worked");
            bool isHours = int.TryParse(Console.ReadLine(), out var hours);
            if (!isHours)
            {
                Console.WriteLine("not a valid hour");
            }

            var pay = hours * rate;

            if (hours > 0 && hours <= 40)
            {
                Console.WriteLine($"Total Gross Pay is Rs.{pay}");
            }
            else if (hours > 40)
            {
                var overHours = hours - 40;
                pay = (int)(pay + (overHours * rate * 0.5));
                Console.WriteLine($"Great! you worked a lot, Total gross pay is Rs.{pay}");
            }

            var tax = (pay * 20) / 100;

            Console.WriteLine($"tax is {tax}");

            var netPay = pay - tax;
            Console.WriteLine($"net pay is {netPay}");
        }
    }
}
