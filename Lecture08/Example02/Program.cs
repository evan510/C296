using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Employee
    {
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hi");
        }
    }

    public class sales : Employee
    {
        public void Say()
        {
            sales.SayHello("HI");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee a = new Employee();
            a.SayHello();
        }
    }
}