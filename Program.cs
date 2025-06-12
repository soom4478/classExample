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
            public static int counter = 0;
            public void CounterParent()
            {
                Parent.counter++;
            }
            public Parent() { Console.WriteLine("Parent()"); }
            public Parent(int name) { Console.WriteLine("Parent()"); }
            public Parent(string param) { Console.WriteLine("Parent()"); }
        }
         class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
            public Child() : base(10) { Console.WriteLine("Child():base(int)"); }
            public Child(string input) : base(input) { Console.WriteLine("Child(input):base(input)"); }

        }
        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Parent parent = new Parent();
            Child child = new Child();

            parent.CounterParent();
            child.CounterParent();
            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
