
////----------------file handling concept in c#

//using System;
//using System.IO;

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //FileInfo f1 = new FileInfo(@"c:\demo\sample.txt");
//        //Console.WriteLine("File name is : "+f1.Name);
//        //Console.WriteLine("File Extension is : " + f1.Extension);
//        //Console.WriteLine("File FullName is : " + f1.FullName);
//        //Console.WriteLine("File Length is : " + f1.Length);
//        //Console.WriteLine("File LastAccessTime is : " + f1.LastAccessTime);
//        //Console.WriteLine("File LastWriteTime is : " + f1.LastWriteTime);
//        //Console.WriteLine("File Directory is : " + f1.Directory);

//        //DirectoryInfo f2 = new DirectoryInfo(@"c:\demo");
//        //Console.WriteLine("Directory name is : " + f2.Name);
//        //Console.WriteLine("Directory FullName is : " + f2.FullName);
//        //Console.WriteLine("Directory Exists ? " + f2.Exists);
//        //Console.WriteLine("Directory LastAccessTime is : " + f2.LastAccessTime);
//        //Console.WriteLine("Directory LastWriteTime is : " + f2.LastWriteTime);
       
//        //DriveInfo f3 = new DriveInfo("c:\\");
//        //Console.WriteLine("DriveInfo name is : " + f3.Name);
//        //Console.WriteLine("DriveInfo total size is : " + f3.TotalSize);
//        //Console.WriteLine("DriveInfo TotalFreeSpace is : " + f3.TotalFreeSpace);
//        //Console.WriteLine("DriveInfo volume label is : " + f3.VolumeLabel);
//        //Console.WriteLine("DriveInfo AvailableFreeSpace is : " + f3.AvailableFreeSpace);

//        //Directory.CreateDirectory(@"c:\\demo\\demo123");
//        ////Directory.Move
//        ////Directory.Delete

//        //string sourceDirectory = @"c:\demo\source";
//        //string destinationDirectory = @"c:\demo\destination";
//        //Directory.Move(sourceDirectory, destinationDirectory);


//        string sourcedirectory = @"C:\demo\source";   //a.txt
//        string destinationdirectory = @"C:\demo\destination";
//        string backupdirectory = @"C:\demo\Backup";
//        try
//        {
//            if (Directory.Exists(sourcedirectory))
//            {
//                if (Directory.Exists(destinationdirectory))
//                {
//                    //Directory.Delete(destinationdirectory);
//                    Directory.Move(destinationdirectory, backupdirectory + DateTime.Now.ToString("_MMMdd_yyyy_HHmmss"));
//                    Directory.Move(sourcedirectory, destinationdirectory);
//                }
//                else
//                {
//                    Directory.Move(sourcedirectory, destinationdirectory);
//                }
//            }

//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }






//        Console.ReadLine();
//    }
//}
