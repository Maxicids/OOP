using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Lab12
{
    static class Reflector
    {
        public static void Analize(object obj, string path = "")
        {
            if (path == "")
            {
                Console.WriteLine("There is now path");
                return;
            }

            Type t = obj.GetType();

            var fullInfo = "";
            fullInfo += GetBuildName(t);
            fullInfo += PublicCtor(t);
            var methods = GetPublicMethods(t);
            fullInfo += "Public methods: ";
            foreach (string method in methods)
            {
                fullInfo += method + " ";
            }
            fullInfo += "\n";
            fullInfo += "Public interfaces: ";
            var interfaces = GetInterfaces(t);
            foreach (string i in interfaces)
            {
                fullInfo += i + " ";
            }
            using (var sw = new StreamWriter(path))
            {
                sw.Write(fullInfo);
            }

            return;
        }
        static string GetBuildName(Type t)
        {
            return "Build name, where object defined: " + t.Assembly.FullName + "\n";
        }
        static string PublicCtor(Type t)
        {
            foreach (ConstructorInfo ctor in t.GetConstructors())
            {
                if (ctor.IsPublic)
                {
                    return "Has a public constructor\n";
                }
            }
            return "Doesn't have a public constructor";
        }
        static IEnumerable<string> GetPublicMethods(Type t)
        {
            var result = new List<string>();
            foreach (MethodInfo method in t.GetMethods().Where(m => m.IsPublic))
            {
                result.Add(method.Name);
            }
            return result;
        }
        static IEnumerable<string> GetInterfaces(Type t)
        {
            var result = new List<string>();
            foreach (var i in t.GetInterfaces())
            {
                   result.Add(i.Name);
            }
            return result;
        }
        static IEnumerable<string> GetFieldsAndProperties(Type t)
        {
            var result = new List<string>();
            foreach (FieldInfo field in t.GetFields())
            {
                    result.Add(field.Name);
            }
            foreach (PropertyInfo property in t.GetProperties())
            {
                result.Add(property.Name);
            }
            return result;
        }

        public static void GetMethods(object obj, string path = "")
        {
            if (path == "")
            {
                Console.WriteLine("There is now path");
                return;
            }

            Type t = obj.GetType();
            string result = "\nMethods: ";
            foreach (MethodInfo method in t.GetMethods())
            {
                ParameterInfo[] lst = method.GetParameters();
                foreach (ParameterInfo par in lst)
                {
                    Console.WriteLine(par.ParameterType);
                    if(par.ParameterType == typeof(System.Int32))
                    {
                        
                        result += method.Name + " ";
                    }
                }
            }

            using (var sw = new StreamWriter(path, true))
            {
                sw.Write(result);
            }
            return;
        }

        public static object Create(object obj)
        {
            Type t = obj.GetType();
            return Activator.CreateInstance(t); 
        }

        public static void Invoke(object obj, string path = "")
        {
            if (path == "")
            {
                Console.WriteLine("There is now path");
                return;
            }
            string fullInfo = "";
            using (var sw = new StreamReader(path))
            {
                fullInfo = sw.ReadLine();
            }
            if (fullInfo != null)
            {
                string[] elems = fullInfo.Split(' ');

                object[] par = new object[elems.Length - 1];
                for (int i = 1; i < elems.Length;i++)
                {
                    par[i - 1] = elems[i];
                }
                Type t = obj.GetType();
                foreach (MethodInfo method in t.GetMethods())
                {
                    if (elems[0] == method.Name)
                    {
                        method.Invoke(obj, par);
                    }
                }

            }
        }
    }
}
