using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class CompareTask : IComparer<Task>
    {
        public int Compare(Task first, Task second)
        {
            // CompareTo() method
            return second.CompareTo(first);
        }
    }
}