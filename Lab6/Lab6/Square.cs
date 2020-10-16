using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Square : Rectangle
    {
        int a;
        public int A
        {
            get { return a; }
            set
            {
                if ((value > 0) && (value <= 100))
                {
                    a = value;
                }
            }
        }

        public Square()
        {
            this.numberOfCorners = NumberOfCorners.Four;
            this.additionalInfo.color = "yellow";
            this.additionalInfo.Dimension = "2d";
        }
        public override int Square_s()
        {
            Console.WriteLine("Square of square is " + (a * a));
            return a * a;
        }
        public override string ToString()
        {
            return "Side: " + a;
        }
    }
}
