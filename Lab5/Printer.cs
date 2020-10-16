using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Printer
    {
        public virtual void iAmPrinting(Figure obj)
        {
            if (obj is Circle)
            {
                Console.WriteLine("Circle");
            }
            if (obj is Rectangle)
            {
                if (obj as Square != null)
                {
                    Console.WriteLine("Square");
                } 
                else
                {
                    Console.WriteLine("Rectangle");
                }
            }
            Console.WriteLine(obj.ToString() + "\n");
        }
    }
}
