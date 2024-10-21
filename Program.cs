//using PracticalEvaluationDevanand.Task2;
//using PracticalEvaluationDevanand.Task9;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using PracticalEvaluationDevanand.Task7;
//using Task = PracticalEvaluationDevanand.Task9.Task;
//using TaskStatus = PracticalEvaluationDevanand.Task9.TaskStatus;

//namespace PracticalEvaluationDevanand
//{
//    internal class Program
//    {
//        static void Main(string[] args)
        //{
            /*
             //TASK _02
            Console.WriteLine("Create a Bank Account:");
            BankAccount EDSTEM123AXIS = new BankAccount("EDSTEM123AXIS", 0, "DEVANAND");

            EDSTEM123AXIS.DisplayAccountDetails();

            Console.WriteLine("Enter the deposit amount to EDSTEM123AXIS:");
            double depositAmount;
            while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
            {
                Console.WriteLine("Please enter an amount greater than 0:");
            }

            EDSTEM123AXIS.Deposit(depositAmount);
            Console.WriteLine("New balance Rs." + depositAmount + ":Balance Rs." + EDSTEM123AXIS.Balance);

            Console.WriteLine("Enter amount to withdraw from EDSTEM123AXIS:");
            double withdrawAmount;
            while (!double.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
            {
                Console.WriteLine("Please enter amount greater than 0:");
            }

            EDSTEM123AXIS.Withdraw(withdrawAmount);
            Console.WriteLine("New balance Rs." + withdrawAmount + ": Balance Rs." + EDSTEM123AXIS.Balance);
            */


            //TASK_07

            //var processor = new Debugging.Calculator();
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //processor.ProcessNumbers(numbers);

            //TASK_09
            /*
            Task task = new Task("Complete TDMS project ", TaskPriority.High, new TaskDuration(12, 30));
            Console.WriteLine("Task Created:");
            Console.WriteLine(task);
            if (task.UpdateStatus(TaskStatus.InProgress))
            {
                Console.WriteLine("Task status updated to InProgress.");
            }
            Console.WriteLine(task);
            
            if (task.UpdateStatus(TaskStatus.Complete))
            {
                Console.WriteLine("Task status updated to Complete.");
            }
            Console.WriteLine(task);
            
            if (!task.UpdateStatus(TaskStatus.New))
            {
                Console.WriteLine("Complete can't go back to New");
            }
            Console.WriteLine(task);
            */
//        }
//    }
//}
