using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab13
{
    class MMVLog
    {
        string path = "";
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                if (value != null)
                {
                    path = value;
                }
                else
                {
                    throw new Exception("Path value is null");
                }
                
            }
        }
        public MMVLog(string _path)
        {
            Path = _path;
            using (var sw = new StreamWriter(_path))
            {
                DateTime Date = new DateTime();
                sw.Write("Log has been created at " + Date);
            }

        }
        public void WriteToLog(string message = "")
        {
            if (message != "")
            {
                using (StreamWriter sw = new StreamWriter(Path, true))
                {
                    DateTime Date = new DateTime();
                    sw.WriteLine(Date + " : " + message);
                }
            }
            else
            {
                throw new Exception("Message is empty");
            }
            
        }
        public void ReadFromLog()
        {
            Console.WriteLine("\n_____________Log_____________");
            using (StreamReader sr = new StreamReader(Path))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("_____________End_____________");
        }
        public void FindInLog(string keyword)
        {
            Console.WriteLine("__Logs which contains " + keyword + "__ ");
            new List<string>(File.ReadAllLines(Path)).Where(l => l.Contains(keyword)).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("_____________End_____________");
        }
    }
}
