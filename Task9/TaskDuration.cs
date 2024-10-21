﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task9
{
    public struct TaskDuration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public TaskDuration(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public override string ToString()
        {
            return $"{Hours}h {Minutes}m";
        }
    }
}
