using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    static class MMVDirInfo
    {
        public static void GetDirInfo(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (dirInfo.Exists)
            {
                Console.WriteLine("\n_________Directory Info________");
                Console.WriteLine($"Name: {dirInfo.Name}");
                Console.WriteLine($"Number of files: {Directory.GetFiles(path).Length}");
                Console.WriteLine($"Number of subdirectories: {Directory.GetDirectories(path).Length}");
                Console.WriteLine($"Name: {dirInfo.Parent}");
                Console.WriteLine($"Path: {dirInfo.FullName}");
                Console.WriteLine($"Creation time: {dirInfo.CreationTime}");
                Console.WriteLine($"Root: {dirInfo.Root}");
                Console.WriteLine("_____________End_____________");
            }
            else
            {
                throw new Exception("dirInfo do not exist");
            }
                
        }
    }
}
