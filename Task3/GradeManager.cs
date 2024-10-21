//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticalEvaluationDevanand.Task3
//{
//    internal class GradeManager
//    {
//        static void Main(string[] args)
//        {
//            int size = 5;
//            double[] grades = new double[size];
//            int gradeCount = 0;
//            Console.WriteLine("Enter marks between 0 and 100 / type 'exit' to finish:");
//            while (true)
//            {
//                if (gradeCount == grades.Length)
//                {
//                    Array.Resize(ref grades, grades.Length + 5);
//                }
//                string input = Console.ReadLine();
//                if (input.ToLower() == "exit")
//                {
//                    break;
//                }
//                double grade;
//                if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
//                {
//                    grades[gradeCount] = grade;
//                    gradeCount++;
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input. Please enter a grade between 0 and 100 or type 'exit' to finish:");
//                }
//            }
//            if (gradeCount == 0)
//            {
//                Console.WriteLine("No grades entered");
//                return;
//            }

//            double sum = 0;
//            for (int i = 0; i < gradeCount; i++)
//            {
//                sum += grades[i];
//            }
//            double average = sum / gradeCount;
//            Console.WriteLine($"Class average: {average}");

//            double highest = grades[0];
//            double lowest = grades[0];
//            for (int i = 1; i < gradeCount; i++)
//            {
//                if (grades[i] > highest)
//                {
//                    highest = grades[i];
//                }
//                if (grades[i] < lowest)
//                {
//                    lowest = grades[i];
//                }
//            }
//            Console.WriteLine($"Highest grade: {highest}");
//            Console.WriteLine($"Lowest grade: {lowest}");
            
//            int passCount = 0;
//            int failCount = 0;
//            for (int i = 0; i < gradeCount; i++)
//            {
//                if (grades[i] >= 50)
//                {
//                    passCount++;
//                }
//                else
//                {
//                    failCount++;
//                }
//            }
//            Console.WriteLine($"Number of students passed: {passCount}");
//            Console.WriteLine($"Number of students failed: {failCount}");
//        }

//    }
        

    
//}
