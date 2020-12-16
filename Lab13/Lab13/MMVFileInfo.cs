using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab13
{
    class MMVFileInfo
    {
        public static void GetFileInfo(string path)
        {
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("\n___________File Info_________");
                Console.WriteLine("Name: {0}", fileInf.Name);
                Console.WriteLine("Path : {0}", path);
                Console.WriteLine("Creation time: {0}", fileInf.CreationTime);
                Console.WriteLine("Size: {0}", fileInf.Length);
                Console.WriteLine("_____________End_____________");
            }
            else
            {
                throw new Exception("Fileinfo do not exist");
            }
        }
    }
}
