using System;

namespace CsharpIcomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] People = new Person[]
            {
                new Person{FirstName = "Kelly", LastName = "Jones", Nationality = "American", DateOfBirth = new DateTime(1982,04,07)},
                new Person{FirstName = "William", LastName = "Ross", Nationality = "Canadian", DateOfBirth = new DateTime(1989,02,15)},
                new Person{FirstName = "Amin", LastName = "Resvokosky", Nationality = "Russian", DateOfBirth = new DateTime(1977,09,10)},
                new Person{FirstName = "Bilky", LastName = "Briya", Nationality = "India", DateOfBirth = new DateTime(1977,09,10)}



            };
            Console.WriteLine();
            Console.WriteLine("-Display array info by with out calling IComparable-");
            //defualt sort using Icomparable of person class 
            foreach (Person person in People)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("-Sort by using defualt IComparable implementation-");
            Array.Sort(People);
            foreach(Person person in People)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("-Sort by using Icomparer implementation (order by nationality)-");
            var OrderByNationality = new OrderPeopleByNationality();
            Array.Sort(People, OrderByNationality);
            foreach (Person person in People)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }
    }
}
