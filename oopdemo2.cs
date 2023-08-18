// methods demo
using System;

namespace ConsoleApp_SurePrep
{
     class oopdemo2
    {
        static void Main(string[] args)
        {
            method2();

            oopdemo2 obj= new oopdemo2();
            obj.method1();

            Console.ReadLine();
        }

        public void method1()
        {
            Console.WriteLine("public void method");
        }

        static void method2()
        {
            Console.WriteLine("static void method");
        }
    }
}
