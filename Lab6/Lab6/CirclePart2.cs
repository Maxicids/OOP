using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    sealed partial class Circle : Figure
    {
        public Circle()
        {
            this.numberOfCorners = NumberOfCorners.Zero;
            this.additionalInfo.color = "brown";
            this.additionalInfo.Dimension = "2d";
        }
    }
}
