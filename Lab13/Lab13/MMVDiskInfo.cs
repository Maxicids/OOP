using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    class MMVDiskInfo
    {
        static public void GetDriveInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("_________Drivers Info________");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Capacity: {drive.TotalSize}");
                    Console.WriteLine($"Free space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"mark: {drive.VolumeLabel}");
                }
                else
                {
                    //exception
                }
                Console.WriteLine();
            }
            Console.WriteLine("_____________End_____________");
        }
    }
}
