using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Task
    {
        public Task(int id_, int timeR_, int timeD_, int timeP1_,  int timeP2_)
        {
            taskId = id_;
            timeR = timeR_;
            timeP1 = timeP1_;
            timeD = timeD_;
            timeP2 = timeP2_;
            
            caluclateTimes();
        }
        public void caluclateTimes()
        {
            timeOfFinishOperationR = timeR;
            timeOfFinishOperationP1 = timeOfFinishOperationR + timeP1;
            timeOfFinishOperationP2 = timeOfFinishOperationR + timeD + timeP2;
        }
        public void caluclateTimes(Task predecessor)
        {
            timeOfFinishOperationR = predecessor.timeOfFinishOperationR + timeR; //timeR, jeśli nie traktować R jako kolejną maszyne
            timeOfFinishOperationP1 = Math.Max(
                timeOfFinishOperationR,
                predecessor.timeOfFinishOperationP1
            ) + timeP1;
            timeOfFinishOperationP2 = Math.Max(
                timeOfFinishOperationR + timeD,
                predecessor.timeOfFinishOperationP2
            ) + timeP2;
        }
        public int CompareTo(Task second)
        {
            int sum1 = timeP1 + timeP2;
            int sum2 = second.timeP1 + second.timeP2;
            int compareDate = sum1.CompareTo(sum2);
            if (compareDate == 0)
            {
                return timeD.CompareTo(second.timeD);
            }
            return compareDate;
        }
        public override string ToString()
        {
            return "Task: " + taskId + " " + timeR + " " + timeP1 + " " + timeD + " " + timeP2;
        }
        public int taskId { get; }
        public int timeOfFinishOperationR { get; set; }
        public int timeOfFinishOperationP1 { get; set; }
        public int timeOfFinishOperationP2 { get; set; }
        public int timeP1 { get; }
        public int timeR { get; }
        public int timeP2 { get; }
        public int timeD { get; }
    }
}
