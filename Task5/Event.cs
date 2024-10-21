using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalEvaluationDevanand.Task5
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime StartDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndDateTime
        {
            get { return StartDateTime.Add(Duration); }
        }
        public TimeSpan TimeUntilEvent
        {
            get { return StartDateTime - DateTime.Now; }
        }
        public override string ToString()
        {
            return $"Event: {Name}, Start: {StartDateTime}, Duration: {Duration}, Ends: {EndDateTime}, Time Until Event: {TimeUntilEvent}";
        }
    }
}
