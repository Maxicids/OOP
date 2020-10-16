using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public abstract class Figure 
    {
        public abstract int Square_s();

        public NumberOfCorners numberOfCorners;
        public enum NumberOfCorners
        {
            Zero,
            One,
            Two,
            Three,
            Four
        }

        public struct AdditionalInfo
        {
            public string color;
            public string Dimension;
        }
        public AdditionalInfo additionalInfo;
        public virtual void resizing()
        {
            Console.WriteLine("Size has been changed");
        }
        public abstract bool DoClone();
    }
}
