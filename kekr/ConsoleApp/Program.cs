using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Classes;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Mogen", "Munjasa");
            var person2 = new Person("Abe", "Lorentzen");

            Console.WriteLine(person1.SayHello());
            Console.WriteLine(person1.SayHello(person2));

            Console.ReadLine();
        }
    }
}
