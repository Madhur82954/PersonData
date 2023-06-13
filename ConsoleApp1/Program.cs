using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    //UC-1
    public class Person
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
    public class Program
    {
        //UC-2
        public void RetrieveTop2(List<Person> persons)
        {
            foreach (Person person in persons.FindAll(e => e.Age > 60).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + " Age : " + person.Age);
            }
        }
        //UC-3
        public void CheckTeenAge(List<Person> persons)
        {
            if (persons.Any(e=>e.Age>=13 &&e.Age<=18))
            {
                Console.WriteLine("Some Tennagers Are present");
            }
            else
            {
                Console.WriteLine("No Such Records");
            }
        }
        
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { SSN = 1, Name = "Madhur", Address = "jkasdial", Age = 18 },
                new Person { SSN = 2, Name = "naman", Address = "hjkasdll", Age = 25 },
                new Person { SSN = 3, Name = "vishal", Address = "kiweiaka", Age = 35 },
                new Person { SSN = 4, Name = "Aman", Address = "nmzxbgsd", Age = 65 },
                new Person { SSN = 5, Name = "shubham", Address = "poqweuih", Age = 85 }
            };
            Program p = new Program();
            p.RetrieveTop2(people);
            p.CheckTeenAge(people);
        }
    }
}
