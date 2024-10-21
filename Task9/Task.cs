//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PracticalEvaluationDevanand.Task9
//{
//    public class Task
//    {
//        public string Title { get; set; }
//        public TaskPriority Priority { get; set; }
//        public TaskStatus Status { get; private set; }
//        public TaskDuration Duration { get; set; }

//        public Task(string title, TaskPriority priority, TaskDuration duration)
//        {
//            Title = title;
//            Priority = priority;
//            Status = TaskStatus.New;
//            Duration = duration;
//        }

//        public bool UpdateStatus(TaskStatus newStatus)
//        {
//            if (Status == TaskStatus.Complete && newStatus == TaskStatus.New)
//            {
//                Console.WriteLine("Error: Cannot change status from Complete to New.");
//                return false;
//            }

//            Status = newStatus;
//            return true;
//        }

//        public override string ToString()
//        {
//            return $"Title: {Title}, Priority: {Priority}, Status: {Status}, Duration: {Duration}";
//        }

//        static void Main(string[] args)
//        {
            
//                Task task = new Task("Complete TDMS project ", TaskPriority.High, new TaskDuration(12, 30));
//                Console.WriteLine("Task Created:");
//                Console.WriteLine(task);
//                if (task.UpdateStatus(TaskStatus.InProgress))
//                {
//                    Console.WriteLine("Task status updated to InProgress.");
//                }
//                Console.WriteLine(task);

//                if (task.UpdateStatus(TaskStatus.Complete))
//                {
//                    Console.WriteLine("Task status updated to Complete.");
//                }
//                Console.WriteLine(task);

//                if (!task.UpdateStatus(TaskStatus.New))
//                {
//                    Console.WriteLine("Complete can't go back to New");
//                }
//                Console.WriteLine(task);
               
//        }
//    }
//}

