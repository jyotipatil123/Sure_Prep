//using ConsoleApp_SurePrep;
//using Phase1Section4._7b;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace mainprogram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            runApp();

//            Console.ReadLine();
//        }

//        public static void runApp()
//        {
//            SingleLinkedList list = new SingleLinkedList();

//            Node n = new Node();

//            n.Data = "root";

//            list.add(n);

//            for (int i = 0; i < 10; i++)
//            {
//                Node node = new Node();
//                node.Data = Convert.ToString(i);
//                list.add(node);
//            }

//            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

//            n = list.getRoot();
//            while (n != null)
//            {
//                Console.WriteLine(n.Data);
//                n = list.getNext();
//            }
//        }
//    }
//}


