using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        private const string TextHello = "Hello";

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string SayHello()
        {
            return TextHello;
        }
        public string SayHello(Person person)
        {
            return TextHello + $" {person.FirstName} {person.LastName}";
        }
    }
}
