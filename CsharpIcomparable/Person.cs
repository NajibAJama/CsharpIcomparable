using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIcomparable
{
    public class Person:IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth{ get; set; }
        public string Nationality { get; set; }
        //defualt compareTo > compares FirstName 
        public int CompareTo(object obj)
        {
            Person otherPerson = (Person)obj;
            return this.FirstName.CompareTo(otherPerson);
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName}: {LastName}: {DateOfBirth.ToShortDateString()}: {Nationality}:";
        }
    }
}
