using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MMVLog log = new MMVLog(@"D:\Epam\OOP\Lab13\Lab13\MMVLog.txt");
                log.WriteToLog("An instance of the class MMVLog has been created");
                log.WriteToLog("An instance of the class");
                log.WriteToLog("MMVLog");
                log.FindInLog("MMVLog");
                log.ReadFromLog();

                MMVDiskInfo.GetDriveInfo();
                MMVFileInfo.GetFileInfo(@"D:\Epam\OOP\Lab13\Lab13\MMVLog.txt");
                MMVDirInfo.GetDirInfo(@"D:\Epam\OOP\Lab13\Lab13");

                MMVFileManager.DiskFilesAndDir(@"D:\Epam\OOP\");
                MMVFileManager.CreateZIP(@"D:\Epam\OOP\Zip");
                MMVFileManager.ExtractZIP(@"D:\Epam\OOP\Extr");


                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exceptions: " + e.Message +
                "\nin method " + e.TargetSite);
            }
            
        }
    }
}
