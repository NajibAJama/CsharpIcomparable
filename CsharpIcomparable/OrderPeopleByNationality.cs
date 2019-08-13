using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIcomparable
{
    public class OrderPeopleByNationality : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            //if nationality is the same order by FirstName 
            if(x.Nationality == y.Nationality)
            {
                return x.FirstName.CompareTo(y.FirstName);
            }
            return x.Nationality.CompareTo(y.Nationality);
           
        }
    }
}
