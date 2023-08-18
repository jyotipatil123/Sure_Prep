////  properties 
//using System;

//namespace ConsoleApp_SurePrep
//{
//    class myclass
//    {
//        string c, c1;
//        public int myid { get; set; }  // automatic property
//        public string name { get; set; }
//        public int age { get; }  //read only
//        public string city 
//        { 
//            set
//            {
//                c= value;
//            }
//        }     // write only    

//        public string country
//        {
//            get
//            {
//                return c1;
//            }
//            set
//            {
//                c1= value;
//            }
//        }

//        int age2;
//        public int Age
//        {
//            get
//            {
//                if (age2 > 18)
//                {
//                    return age2;
//                }
//                else
//                {
//                    return 0;
//                }
//            }
//            set
//            { 
//                age2 = value; 
//            }
//        }
//    }
//     class propertydemo
//    {
//        static void Main(string[] args)
//        {
//            // get, set---accessors 
//            // get --read only
//            // set-- write only

//            myclass obj= new myclass();
//            obj.myid = 1;
//            obj.name = "anita";

//            myclass obj1= new   myclass();
//            obj1.myid = 2;
//            obj1.name = "sunita";

//            Console.WriteLine(obj.myid);
//            Console.WriteLine(obj.name);
//            Console.WriteLine(obj1.myid);
//            Console.WriteLine(obj1.name);

//            Console.WriteLine("Age is :" + obj.age);
//            obj.city = "Mysore";

//            //   Console.WriteLine("City is : " + obj.city);

//            obj.country = "India";
//            Console.WriteLine(obj.country);


//            obj.Age = 20;
//            Console.WriteLine(obj.Age);

//            Console.ReadLine();
//        }
//    }
//}
