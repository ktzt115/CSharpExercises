using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager
{
    public class DescendingAgeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return y.Age - x.Age;
        }
    }
    public class AscendingAgeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }

    public class AscendingZipcodeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Zipcode - y.Zipcode;
        }
    }

    public class DescendingZipcodeSorter : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return y.Zipcode - x.Zipcode;
        }
    }

    public class AscendingStateAndCity : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if(x.State.CompareTo(y.State) == 0)
            {
                return x.City.CompareTo(y.City);
            }
            else
            {
                return x.State.CompareTo(y.State);
            }
        }
    }
}
