using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    sealed class Circle : Figure
    {
        int radius;
        public override void Square()
        {
            Console.WriteLine("Square of circle is " + (radius*radius)* Math.PI);
        }
        public override void resizing()
        {
            Console.WriteLine("Input new radius");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Radius: " + radius;
        }

        public override bool DoClone()
        {
            if (Convert.ToBoolean(radius))
            {
                return true;
            }
            return false;
        }
    }
}
