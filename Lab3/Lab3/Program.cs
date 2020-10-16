using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks.Dataflow;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(5, Type.rectangle);
            Console.WriteLine(rec.printObj());
            rec.Height = -10;
            rec.Width = 7;
            Console.WriteLine(rec.printObj());
            Console.WriteLine(rec.printHeight());
            Console.WriteLine(rec.printWidth());
            Console.WriteLine($"The area of a rectangle is {rec.area()}");
            rec.perimeter();
            int semiPerimeter = 0, height = rec.Height, width = rec.Width;
            rec.status(ref height, ref width, out semiPerimeter);

            Console.WriteLine(semiPerimeter);
            Console.WriteLine(rec.id);
            Rectangle rec1 = new Rectangle(10, 10, Type.square);
            Console.WriteLine(rec1.id);
            Rectangle rec2 = new Rectangle(10, 15, Type.rectangle);
            Console.WriteLine(rec2.id);

            Rectangle rec3 = new Rectangle(13, 15, Type.random);
            Rectangle rec4 = new Rectangle(15, 15, Type.rhombus);
            Rectangle rec5 = new Rectangle(15, 15, Type.square);
            Rectangle rec6 = new Rectangle(10, 15, Type.rectangle);

            Rectangle[] rectangles = new Rectangle[] { rec, rec1, rec2, rec3, rec4, rec5,rec6 };
            Rectangle.numberOfRectangles(rectangles);

            Console.WriteLine(rec1.Equals(rec2));

            Console.WriteLine(rec);


            Person Max = new Person();
            Max.height = 184;
            Max.weight = 73;
            Max.showHeight();
            Max.showWeight();
            Console.WriteLine(Max is object);
            Console.WriteLine(Max.GetType());
            Console.WriteLine(rec);


            var rec8 = new { height = 10, width = 34, type = Type.random };//объект без класса
            Console.WriteLine(rec8.type);
        }
    }

}
