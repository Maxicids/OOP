using System;
using Lab11;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Reflector.Analize(rec, @"D:\Epam\OOP\Lab12\Lab12\Out.txt");
            Reflector.GetMethods(rec, @"D:\Epam\OOP\Lab12\Lab12\Out.txt");
            Console.WriteLine(rec.area());
            Reflector.Invoke(rec, @"D:\Epam\OOP\Lab12\Lab12\In.txt");
            Console.WriteLine(rec.area());

            object rectangle = Reflector.Create(rec);
            Console.WriteLine(rectangle.ToString());
            Console.ReadKey();
        }
    }
}
