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

        public override string ToString()
        {
            return "Side: " + a;
        }
    }
}
