using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExample
{
    class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int name) { Console.WriteLine("Parent()"); }
            public Parent(string param) { Console.WriteLine("Parent()"); }
        }
         class Child : Parent
        {
            public Child() : base(10) { Console.WriteLine("Child():base(int)"); }
            public Child(string input) : base(input) { Console.WriteLine("Child(input):base(input)"); }

        }
        static void Main(string[] args)
        {
        }
    }
}
