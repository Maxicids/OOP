using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            var groups = new List<Group>();
            var students = new List<Student>();
            for(int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, "Group " + i));
            }

            for (int i = 0; i < 300;i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), rnd.Next(17, 23))
                {
                    Group = groups[i % 9]
                };
                students.Add(student);
            }

            var binFormater = new BinaryFormatter();

            using(var file = new FileStream("BinaryGroups.bin", FileMode.OpenOrCreate))
            {
                binFormater.Serialize(file, groups);
            }

            using (var file = new FileStream("BinaryGroups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormater.Deserialize(file) as List<Group>;
                if (newGroups != null)
                {
                    foreach(var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }
            Console.WriteLine();
            var soapFormater = new SoapFormatter();

            using (var file = new FileStream("SoapGroups.soap", FileMode.OpenOrCreate))
            {
                soapFormater.Serialize(file, groups.ToArray());
            }

            using (var file = new FileStream("SoapGroups.soap", FileMode.OpenOrCreate))
            {
                var newGroups = soapFormater.Deserialize(file) as Group[];
                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group); 
                    }
                }
            }
            Console.WriteLine();

            var xmlFormatter = new XmlSerializer(typeof(List<Group>));//тип в который сериализовываем
            using (var file = new FileStream("XMLGroups.xml", FileMode.OpenOrCreate))
            {
                xmlFormatter.Serialize(file, groups);
            }

            using (var file = new FileStream("XMLGroups.xml", FileMode.OpenOrCreate))
            {
                var newGroups = xmlFormatter.Deserialize(file) as List<Group>;
                if (newGroups != null)
                {
                    foreach (var group in newGroups)
                    {
                        Console.WriteLine(group);
                    }
                }
            }

            Console.WriteLine();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));

            using (var file = new FileStream("JsonStudents.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, students);
            }

            using (var file = new FileStream("JsonStudents.json", FileMode.OpenOrCreate))
            {
                var newStudents = jsonFormatter.ReadObject(file) as List<Student>;
                if (newStudents != null)
                {
                    foreach (var student in newStudents)
                    {
                        Console.WriteLine(student);
                    }
                }
            }

            Console.WriteLine();
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("D:\\Epam\\OOP\\Lab14\\Lab14\\bin\\Debug\\netcoreapp3.1\\XMLGroups.xml");
            XmlElement xRoot = xmlDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("Group[Name='Group 1']");
            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine(n.OuterXml);
            }
            childnodes = xRoot.SelectNodes("Group[Number='4']");
            foreach (XmlNode n in childnodes)
            {
                Console.WriteLine(n.OuterXml);
            }
            
            using (var file = new FileStream("JsonStudents.json", FileMode.OpenOrCreate))
            {
                var newStudents = jsonFormatter.ReadObject(file) as List<Student>;
                var sortedStudents = newStudents.Where(m => m.Group.Number == 5);
                if (newStudents != null)
                {
                    using (var fileSort = new FileStream("SortedStudents.json", FileMode.OpenOrCreate))
                    {
                        jsonFormatter.WriteObject(fileSort, sortedStudents);
                    }

                }
            }

            Console.ReadLine();
        }
    }
}
