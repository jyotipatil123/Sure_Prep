//////////////// class and object
//////////////using System;

//////////////namespace ConsoleApp_SurePrep
//////////////{
//////////////     class OopsDemo1
//////////////    {
//////////////        public void function1()
//////////////        {
//////////////            Console.WriteLine("public void function1-OopsDemo1 class");
//////////////        }
//////////////    }

//////////////    class OopsDemo2 : OopsDemo1      //single level inheritance / single inheritance
//////////////    {
//////////////        public void function2()
//////////////        {
//////////////            Console.WriteLine("public void function2-OopsDemo2 class");
//////////////        }
//////////////    }

//////////////  //  class oopsdemo3 : OopsDemo2       // multi level inheritance 
//////////////    class oopsdemo3 : OopsDemo1         // hierarchical inheritance 
//////////////    {
//////////////        public void function3()
//////////////        {
//////////////            Console.WriteLine("public void function3 --- oopsdemo3 class");
//////////////        }
//////////////    }
//////////////    class MyClass
//////////////    {
//////////////        static void Main(string[] args)
//////////////        {
//////////////            // classes are independent
//////////////            //OopsDemo1 demo = new OopsDemo1();
//////////////            //demo.function1();

//////////////            //OopsDemo2 demo2 = new OopsDemo2();
//////////////            //demo2.function2();


//////////////            // single level inheritance 
//////////////            OopsDemo2 demo = new OopsDemo2();
//////////////            demo.function1();
//////////////            demo.function2();



//////////////            oopsdemo3 demo3 = new oopsdemo3();
//////////////            demo3.function1();
//////////////            demo3.function2();
//////////////            demo3.function3();

//////////////            Console.ReadLine();
//////////////        }
//////////////    }
//////////////}


//////////////=================================================================

////////////// polymorphism
////////////// design : function overloading / operator overloading
////////////// runtime : function overriding

////////////using System;

////////////class MyClass
////////////{
////////////    public void add()
////////////    {
////////////        int a, b;
////////////        a=10; b=20;
////////////        Console.WriteLine("Addition result is : "+(a+b));
////////////    }
////////////    public void add(int a)
////////////    {
////////////        int b= 20;
////////////        Console.WriteLine("Addition result is : " + (a + b));
////////////    }
////////////    public void add(int a, int b)
////////////    {
////////////       Console.WriteLine("Addition result is : " + (a + b));
////////////    }
////////////    public void add(int a, int b, int c)
////////////    {
////////////       Console.WriteLine("Addition result is : " + (a + b+c));
////////////    }
////////////}

////////////class india
////////////{
////////////    static void Main(string[] args)
////////////    {
////////////        MyClass obj= new MyClass();
////////////        obj.add();
////////////        obj.add(3);
////////////        obj.add(4,2);
////////////        obj.add(5,3,2);

////////////        Console.ReadLine();
////////////    }
////////////}

////////////==================================================================
//////////// runtime polymorphism
//////////using System;

//////////class parentclass
//////////{
//////////    public virtual void function1()
//////////    {
//////////        Console.WriteLine("parent class --function1() is invoked ");
//////////    }
//////////}

//////////class childclass : parentclass
//////////{
//////////    public override void function1()
//////////    {
//////////        Console.WriteLine("child class --function1() is invoked ");
//////////    }
//////////}

//////////class MyClass
//////////{
//////////    static void Main(string[] args)
//////////    {
//////////        childclass obj = new childclass();
//////////        obj.function1();

//////////        Console.ReadLine();
//////////    }
//////////}

//////////=============================================================

////////// structures demo

////////using System;
////////using System.Reflection.Emit;

////////struct book
////////{
////////    public int bookid;
////////    public string name;
////////    public string description;

////////    public void function1()
////////    {
////////        Console.WriteLine("function1() is invoked from strcture");
////////    }
////////}

////////class MyClass
////////{
////////    static void Main(string[] args)
////////    {
////////        book obj1= new book();
////////        obj1.bookid = 1;
////////        obj1.name= "C# book";
////////        obj1.description = "Copyright 2021";

////////        Console.WriteLine("Book 1 information : ");
////////        Console.WriteLine(obj1.bookid);
////////        Console.WriteLine(obj1.name);
////////        Console.WriteLine(obj1.description);

////////        //================================================================
////////        book obj2 = new book();
////////        obj2.bookid = 2;
////////        obj2.name = "Asp.net book";
////////        obj2.description = "Copyright 2022";

////////        Console.WriteLine("Book 2 information : ");
////////        Console.WriteLine(obj2.bookid);
////////        Console.WriteLine(obj2.name);
////////        Console.WriteLine(obj2.description);
////////        //==================================================================
////////        book obj3 = new book();
////////        obj3.bookid = 3;
////////        obj3.name = "Ado.net book";
////////        obj3.description = "Copyright 2023";

////////        Console.WriteLine("Book 3 information : ");
////////        Console.WriteLine(obj3.bookid);
////////        Console.WriteLine(obj3.name);
////////        Console.WriteLine(obj3.description);

////////        Console.ReadLine();
////////    }
////////}

////////=========================================

//////// constructors demo

////////using System;

////////class MyClass
////////{
////////    public MyClass()  // default constructor
////////    {
////////        Console.WriteLine("Myclass constructor is invoked");
////////    }
////////}

////////class mainclass
////////{
////////    static void Main(string[] args)
////////    {
////////        MyClass obj= new MyClass();

////////        Console.ReadLine();
////////    }
////////}

////////parameterized constructor


//////using System;

//////class MyClass
//////{
//////    public MyClass()
//////    {
//////        Console.WriteLine("Myclass constructor is invoked");
//////    }
//////    public MyClass(string name)  // parameterized constructor
//////    {
//////        Console.WriteLine("Myclass constructor is invoked"+name);
//////    }
//////}

//////class mainclass
//////{
//////    static void Main(string[] args)
//////    {
//////        MyClass obj = new MyClass();

//////        MyClass obj1 = new MyClass("india");


//////        Console.ReadLine();
//////    }
//////}

//////===================================================================================

//////using System;
//////public class Employee
//////{
//////    public int id;
//////    public String name;
//////    public float salary;
//////    public Employee(int i, String n, float s)
//////    {
//////        id = i;
//////        name = n;
//////        salary = s;
//////    }
//////    public void display()
//////    {
//////        Console.WriteLine(id + " " + name + " " + salary);
//////    }
//////}
//////class TestEmployee
//////{
//////    public static void Main(string[] args)
//////    {
//////        Employee e1 = new Employee(101, "Sonoo", 890000f);

//////        Employee e2 = new Employee(102, "Mahesh", 490000f);

//////        e1.display();
//////        e2.display();

//////        Console.ReadLine();

//////    }
//////}

//////====================================================================

////using System;

////    class User
////    {
////        // Private Constructor
////        private User()
////        {
////            Console.WriteLine("I am Private Constructor");
////        }
////        public static string name, location;

////        public User(string a, string b)
////        {
////            name = a;
////            location = b;
////        }
////    }
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            // The following comment line will throw an error because the constructor is inaccessible
////           // User user = new User();

////            // Only the Default constructor with parameters will invoke
////            User user1 = new User("Suresh", "Hyderabad");

////            Console.WriteLine(User.name + ", " + User.location);

////     // advantage : stop creation of object 
////             Console.ReadLine();
////        }
////    }


//// static constructor

//using System;

//namespace Constructor
//{
//    class Test
//    {
//        //Declaration and initialization of static data member
//        private static int id = 5;
//        public static int Id
//        {
//            get
//            {
//                return id;
//            }
//        }
//        public static void print()
//        {
//            Console.WriteLine("Test.id = " + id);
//        }
//        static void Main(string[] args)
//        {
//            //Print the value of id
//            Test.print();

//            Test obj= new Test();

//        }
//    }
//}


//====================continue from 18th august 2023


//using System;
//using static System.Net.Mime.MediaTypeNames;

//namespace Constructor
//{
//    class Test1
//    {
//        private static int id;
//        //Static constructor, value of data member id is set conditionally here.
//        //This type of initialization is not possible at the time of declaration.
//        static Test1()
//        {
//            if (Test.Id < 10)
//            {
//                id = 20;
//            }
//            else
//            {
//                id = 100;
//            }
//            Console.WriteLine("Static<Class> Constructor for Class Test1 Called..");
//        }
//        public static void print()
//        {
//            Console.WriteLine("Test1.id = " + id);
//        }
//        static void Main(string[] args)
//        {
//            //Print the value of id
//            Test1.print();
//        }
//    }
//}