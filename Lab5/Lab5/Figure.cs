using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    abstract class Figure 
    {
        public abstract void Square();
        public virtual void resizing()
        {
            Console.WriteLine("Size has been changed");
        }
        public abstract bool DoClone();
    }
}
