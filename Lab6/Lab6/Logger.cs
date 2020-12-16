using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab5
{
    class Logger
    {
        public List<Logger> lst = new List<Logger>();

        public DateTime dt = new DateTime();
        public string typeOfLog;
        public string message;

        public void Log(Exception e)
        {
            Logger lg = new Logger();
            lg.message = e.Message;
            lg.dt = DateTime.Now;
            lg.typeOfLog = "Exception";
            lst.Add(lg);
        }

        public void ShowLog()
        {
            Console.Write("\n\nLog exceptions: \n");
            foreach (Logger lg in lst)
            {
                Console.Write(lg.message + lg.dt + "\n");
            }
            Console.Write("\n");
        }

        public void FileLog()
        {
            string writePath = @"D:\Epam\OOP\Lab6\Log.txt";
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.Write("Log exceptions: \n");
                foreach (Logger lg in lst)
                {

                    sw.Write(lg.message + lg.dt + "\n");
                }
                sw.Write("\n");
            }

            
        }
    }
}
