using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class GFG : IComparer<Task>
    {
        public int Compare(Task first, Task second)
        {
            // CompareTo() method
            return second.CompareTo(first);
        }
    }
}