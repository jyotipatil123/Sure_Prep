//using System;
//using System.IO;

//namespace ConsoleApp_SurePrep
//{
//     class filehandlingdemo
//    {
//        static void Main(string[] args)
//        {
//            //Directory.CreateDirectory("c:\\demo\\india123");
//            //Console.WriteLine("Directory is created");


//            //// to retrive all files from a folder

//            //foreach (var item in Directory.GetFiles("C:\\demo"))
//            //{
//            //    Console.WriteLine(item.ToString());
//            //}


//            // stream reader and stream writer 
//            //   string path = "c:\\demo\\sample.txt";

//            //StreamReader rdr= new StreamReader("c:\\demo\\sample.txt");
//            //// content of the file

//            //rdr.BaseStream.Seek (0, SeekOrigin.Begin);

//            //string line = rdr.ReadLine();

//            //while(line != null) 
//            //{
//            //    Console.WriteLine(line);
//            //    line= rdr.ReadLine();
//            //}


//            //// stream writer 
//            //StreamWriter obj = new StreamWriter("c:\\demo\\sample.txt");

//            //obj.Write("this is first line");
//            //obj.Write("this is second line");
//            //obj.Write("this is third line");

//            //obj.Close();


//            // WAP to accept number of lines from the user
//            // store it in the file.


//            //   StreamWriter obj = new StreamWriter("c:\\demo\\sample.txt");
//            //Console.WriteLine("Enter a sentence to add in a file");
//            //string sent = Console.ReadLine();

//            //obj.WriteLine(sent);

//            //obj.Close();

//            // store number of lines inside a file
//            //StreamWriter sw = new StreamWriter("c:\\demo\\sample.txt");
//            //Console.WriteLine("Enter the number of lines you want to enter");

//            //int a = int.Parse(Console.ReadLine());


//            //for (int i = 0; i < a; i++)
//            //{
//            //    string s = Console.ReadLine();
//            //    sw.NewLine = s;
//            //    sw.WriteLine("     ");
//            //    sw.WriteLine(s);                
//            //}
//            //sw.Close();

//            //StreamReader rdr = new StreamReader("c:\\demo\\sample.txt");
//            //// content of the file

//            //rdr.BaseStream.Seek(0, SeekOrigin.Begin);

//            //string line = rdr.ReadLine();

//            //while (line != null)
//            //{
//            //    Console.WriteLine(line);
//            //    line = rdr.ReadLine();
//            //}

//            //============================================================================

//            // Creating a file
//            string myfile = "c:\\demo\\sample.txt";

//            // Appending the given texts
//            using (StreamWriter sw = File.AppendText(myfile))
//            {
//                sw.WriteLine("first line");
//                sw.WriteLine("second line");
//                sw.WriteLine("third line");
//            }


//            // Opening the file for reading
//            using (StreamReader sr = File.OpenText(myfile))
//            {
//                string s;
//                while ((s = sr.ReadLine()) != null)
//                {
//                    Console.WriteLine(s);
//                }
//            }

//            Console.ReadLine();
//        }    
//    }
//}
