using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Aplication
    {
        private List<Task> saveTheBestOrderOfTasks()
        {
            List<Task> theBestOrderOfTasks = new List<Task>(orderOfTasks.Count);
            foreach (Task task in orderOfTasks)
            {
                theBestOrderOfTasks.Add(task);
            }
            return theBestOrderOfTasks;
        }
        private void swap(List<Task> objectArray, int x, int y)
        {
            Task buffer = objectArray[x];
            objectArray[x] = objectArray[y];
            objectArray[y] = buffer;
        }
        public List<Task> addTask(int id_, int timeR_, int timeD_, int timeP1_, int timeP2_)
        {
            orderOfTasks.Add(new Task(id_, timeR_, timeD_, timeP1_, timeP2_));
            int Cmax = calculateFinishTime();
            GFG gg = new GFG();
            orderOfTasks.Sort(gg); // to nie jest NEH tylko ustawianie największego elementu w najlepszym miejscu :<
            int newCmax = Cmax;
            List<Task> theBestOrderOfTasks = saveTheBestOrderOfTasks();
            for (int i = orderOfTasks.Count - 1; i > 0; --i)
            {
                swap(orderOfTasks, i - 1, i);
                newCmax = calculateFinishTime();
                if (newCmax < Cmax)
                {
                    Cmax = newCmax;
                    theBestOrderOfTasks = saveTheBestOrderOfTasks();
                }
            }
            orderOfTasks = theBestOrderOfTasks;
            calculateFinishTime();
            return orderOfTasks;
        }

        public void removeByID(int id_)
        {
            foreach (Task task in orderOfTasks)
            {
                if (task.taskId == id_)
                {
                    orderOfTasks.Remove(task);
                    break;
                }

            }
        }

        public void clearOrderOfTask()
        {
            orderOfTasks.Clear();
        }

        private int calculateFinishTime()
        {
            Task predecessor = orderOfTasks[0];

            orderOfTasks[0].caluclateTimes();
            foreach (Task task in orderOfTasks.Skip(0))
            {
                task.caluclateTimes(predecessor);
                predecessor = task;
            }
            return predecessor.timeOfFinishOperationP2;
        }

        private List<Task> orderOfTasks = new List<Task>();
        public List<Task> getOrderOfTasks() { return orderOfTasks; }
    }
}
