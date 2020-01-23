using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Aplication
    {
        private List<Task> cloneOrderOfTasks(List<Task> newtheBestOrderOfTasks)
        {
            List<Task> theBestOrderOfTasks = new List<Task>(newtheBestOrderOfTasks.Count);
            foreach (Task task in newtheBestOrderOfTasks)
            {
                theBestOrderOfTasks.Add(new Task(task));
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
            CompareTask compareTask = new CompareTask();
            orderOfTasks.Sort(compareTask);
            calculateNewOrder();
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

        private int calculateFinishTime(List<Task> listOfTask)
        {
            Task predecessor = listOfTask[0];
            listOfTask[0].caluclateTimes();
            foreach (Task task in listOfTask.Skip(1))
            {
                task.caluclateTimes(predecessor);
                predecessor = task;
            }
            return predecessor.timeOfFinishOperationP2;
        }
        private void calculateNewOrder()
        {
            List<Task> Subset = new List<Task>();
            foreach (Task task in orderOfTasks)
            {
                Subset.Add(new Task(task));
                calculateNewOrderOfSubset(Subset);
            }
            orderOfTasks = Subset;
        }
        private void calculateNewOrderOfSubset(List<Task> listOfTask)
        {
            int Cmax = calculateFinishTime(listOfTask);
            int newCmax = Cmax;
            List<Task> theBestOrderOfTasks = cloneOrderOfTasks(listOfTask);
            for (int i = listOfTask.Count - 1; i > 0; --i)
            {
                swap(listOfTask, i - 1, i);
                newCmax = calculateFinishTime(listOfTask);
                if (newCmax < Cmax)
                {
                    Cmax = newCmax;
                    theBestOrderOfTasks = cloneOrderOfTasks(listOfTask);
                }
            }
            listOfTask = theBestOrderOfTasks;
        }
        private List<Task> orderOfTasks = new List<Task>();
        public List<Task> getOrderOfTasks() { return orderOfTasks; }
    }
}
