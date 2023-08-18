////using System;
////using System.Collections;

////namespace ConsoleApp_SurePrep
////{
////     class stack_queue
////    {
////        static void Main(string[] args)
////        {
////            Stack s1= new Stack(); //LIFO  last in first out
////            s1.Push(1);      s1.Push(2);    s1.Push(3);      s1.Push(4);   s1.Push(5);      s1.Push(6);

////            Console.WriteLine("Stack elements are : ");
////            foreach (var item in s1)
////            {
////                Console.WriteLine(item);
////            }


////            s1.Pop();

////            Console.WriteLine("Stack elements after removing a item : ");
////            foreach (var item in s1)
////            {
////                Console.WriteLine(item);
////            }

////            // s1.Clear();

////            Console.WriteLine("total count of stack " + s1.Count);
////            //==============================================

////            Queue q1 = new Queue(); //LIFO  last in first out
////            q1.Enqueue(1);       q1.Enqueue(2);    q1.Enqueue(3);  q1.Enqueue(4); q1.Enqueue(5);  q1.Enqueue(6);

////            Console.WriteLine("Queue elements are : ");
////            foreach (var item in q1)
////            {
////                Console.WriteLine(item);
////            }
////            q1.Dequeue();
////            Console.WriteLine("Queue elements after removing a item : ");
////            foreach (var item in q1)
////            {
////                Console.WriteLine(item);
////            }
////           // q1.Clear();
////            Console.WriteLine("total count of queue " + q1.Count);
////            //=================================================



////            Console.ReadLine();
////        }
////    }
////}

////======================================================

//using System;

//class MyClass
//{
//    public static int LinearSearch(int[] numbers, int target)
//    {
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (numbers[i] == target)
//            {
//                return i;
//            }
//        }
//        return -1;
//    }

//    static void Main(string[] args)
//    {

//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int index = LinearSearch(numbers, 5);
//        Console.WriteLine("The number 5 is at index " + index);

//        Console.ReadLine();
//    }
//}
