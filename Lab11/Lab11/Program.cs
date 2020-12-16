using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            foreach(string mnth in month)
            {
                Console.Write(mnth + " ");
            }

            Console.WriteLine("\nInput length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var longMonth = month.Where(mnth => mnth.Length > n);

            foreach (string mnth in longMonth)
            {
                Console.Write(mnth + " ");
            }
            Console.WriteLine();


            var sortedMonth = month.OrderBy(mnth => mnth);

            foreach (string mnth in sortedMonth)
            {
                Console.Write(mnth + " ");
            }
            Console.WriteLine();

            var requestededMonth = month.Where(mnth => mnth.Contains("u") && mnth.Length > 4);

            foreach (string mnth in requestededMonth)
            {
                Console.Write(mnth + " ");
            }
            Console.WriteLine("\n");

            var lst = new List<Rectangle>();
            lst.Add(new Rectangle(15, 10, Type.rectangle));
            lst.Add(new Rectangle(15, 15, Type.square));
            lst.Add(new Rectangle(8, 7, Type.rectangle));
            lst.Add(new Rectangle(16, 16, Type.rhombus));
            lst.Add(new Rectangle(10, 10, Type.square));
            lst.Add(new Rectangle(2, 3, Type.rectangle));
            lst.Add(new Rectangle(18, 18, Type.square));
            lst.Add(new Rectangle(6, 6, Type.rhombus));

            foreach (Rectangle rec in lst)
            {
                Console.WriteLine(rec.ToString());
            }
            Console.WriteLine("\n");


            Console.WriteLine("\nNumber of squares: " + lst.Where(r => r.type == Type.square).Count());
            Console.WriteLine("\nNumber of rectangles: " + lst.Where(r => r.type == Type.rectangle).Count());
            Console.WriteLine("\nNumber of rhombus: " + lst.Where(r => r.type == Type.rhombus).Count());
            Console.WriteLine();

            Console.WriteLine("\nThe biggest square: " + lst.OrderByDescending(rec => rec.area()).Where(r => r.type == Type.square).FirstOrDefault());
            Console.WriteLine("\nThe biggest square: " + lst.Select(r => r.area()).Max());
            Console.WriteLine("\nThe biggest rectangle: " + lst.OrderByDescending(rec => rec.area()).Where(r => r.type == Type.rectangle).FirstOrDefault());
            Console.WriteLine("\nThe biggest rhombus: " + lst.OrderByDescending(rec => rec.area()).Where(r => r.type == Type.rhombus).FirstOrDefault());
            Console.WriteLine();

            Console.WriteLine("\nThe smallest square: " + lst.OrderBy(rec => rec.area()).Where(r => r.type == Type.square).FirstOrDefault());
            Console.WriteLine("\nThe smallest rectangle: " + lst.OrderBy(rec => rec.area()).Where(r => r.type == Type.rectangle).FirstOrDefault());
            Console.WriteLine("\nThe smallest rhombus: " + lst.OrderBy(rec => rec.area()).Where(r => r.type == Type.rhombus).FirstOrDefault());
            Console.WriteLine();


            foreach (Rectangle rec in lst.Where(r => r.type == Type.square && r.Height > 10))
            {
                Console.WriteLine(rec.ToString());
            }
            Console.WriteLine("\n");

            foreach (Rectangle rec in lst.OrderBy(r => r.perimeter()))
            {
                Console.WriteLine(rec.ToString());
            }

            List<int> lst1 = new List<int> { 1, 8, 7, 4, 5, 6 };
            List<int> lst2 = new List<int> { 12, 8, 4, 6, 48, 1 };

            var filtered = from num1 in lst1
                           join num2 in lst2
                           on num1 equals num2
                           orderby num1, num2
                           select new { Num1 = num1, Num2 = num2 };

            var filtered2 = lst1.OrderBy(num => num).Join(lst2.OrderBy(num => num), num1 => num1, num2 => num2, (num1, num2) => new { Num1 = num1, Num2 = num2 });

            foreach (var num in filtered)
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            foreach (var num in filtered2)
            {
                Console.Write(" " + num);
            }


            Console.ReadLine();
        }
    }
}
