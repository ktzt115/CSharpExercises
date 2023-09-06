using System.Threading.Tasks;

namespace ToDoTracker
{
    public class AscendingDueDateSorter : IComparer<ToDoTask>
    {
        int IComparer<ToDoTask>.Compare(ToDoTask t1, ToDoTask t2)
        {
            return t1.DueDate.CompareTo(t2.DueDate);

        }
    }
}