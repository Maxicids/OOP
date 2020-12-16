using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Lab13
{
    class MMVFileManager
    {
        public static void DiskFilesAndDir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            dir.CreateSubdirectory("MMVInspect");
            FileInfo file = new FileInfo(path + "\\MMVInspect" + "\\mmvdirinfo.txt");
            using (StreamWriter sw = new StreamWriter(path + "\\MMVInspect" + "\\mmvdirinfo.txt", true))
            {

                sw.Write("\n============Directory list=============");
                foreach (var item in dir.GetDirectories())
                {
                    sw.WriteLine(item.Name);
                    sw.WriteLine("==Subdirectory list==");
                    foreach (var it in item.GetDirectories())
                        sw.WriteLine(it.Name);
                    sw.WriteLine();
                }
                sw.WriteLine("==============File list==============");
                foreach (var item in dir.GetFiles())
                {
                    sw.WriteLine(item.Name);
                }
                
                //file.Delete();
            }
            File.Copy("D:\\Epam\\OOP\\MMVInspect\\mmvdirinfo.txt", "D:\\Epam\\OOP\\MMVInspect\\mmvdirinfo(1).txt", true);
            File.Delete("D:\\Epam\\OOP\\MMVInspect\\mmvdirinfo.txt");

            dir.CreateSubdirectory("MMVFiles");
            var files = Directory.GetFiles(@"D:\Epam\OOP\Files", "*.txt");
            foreach (string fl in files)
            {
                string name = fl.Substring(@"D:\Epam\OOP\Files".Length + 1);
                File.Copy(Path.Combine(@"D:\Epam\OOP\Files", name), Path.Combine(@"D:\Epam\OOP\MMVFiles", name), true); 
            }
            Directory.Move(@"D:\Epam\OOP\MMVFiles", @"D:\Epam\OOP\MMVInspect\MMVFiles");
        }

        public static void CreateZIP(string dir1)
        {
            string zip = @"D:\Epam\OOP\MMVInspect\MMV.zip";
            ZipFile.CreateFromDirectory(dir1, zip);
        }
        public static void ExtractZIP(string dir1)
        {
            string zip = @"D:\Epam\OOP\MMVInspect\MMV.zip";
            ZipFile.ExtractToDirectory(zip, dir1);
        }
    }
}
