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
            public int variable = 237;
            public void Method()
            {
                Console.WriteLine("부모 메서드");
            }

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
            public string variable = "하이딩";
            public void Method()
            {
                Console.WriteLine("자식 메서드");
            }
            public void CountChild()
            {
                Child.counter++;
            }
            public Child() : base(10) { Console.WriteLine("Child():base(int)"); }
            public Child(string input) : base(input) { Console.WriteLine("Child(input):base(input)"); }

        }
        public static int number = 10; // 가려진 부모 변수
        static void Main(string[] args)
        {
            // 섀도잉
            int number = 10; // 섀도잉 예.number 변수가 지역 변수로 가려짐
            Console.WriteLine(number);
            Console.WriteLine(Program.number);

            // 하이딩
            Child c = new Child();
            Console.WriteLine(c.variable);
            Console.WriteLine(((Parent)c).variable);
            Console.WriteLine((c as Parent).variable);
            c.Method();
            ((Parent)c).Method(); // 하이딩 된 부모의 메서드 접근

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
