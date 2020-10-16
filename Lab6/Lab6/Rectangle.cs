﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Rectangle : Figure, IControlElement
    {
        int height = 1;
        public int Height
        {
            get { return height; }
            set
            {
                if ((value > 0) && (value <= 100))
                {
                    height = value;
                }
            }
        }

        public Rectangle()
        {
            this.numberOfCorners = NumberOfCorners.Four;
            this.additionalInfo.color = "blue" ;
            this.additionalInfo.Dimension = "2d";
        }

        int width = 1;
        public int Width
        {
            get { return width; }
            set
            {
                if ((value > 0) && (value <= 100))
                {
                    width = value;
                }
            }
        }
        public override int Square_s()
        {
            Console.WriteLine("Square of rectangle is " + (height * width));
            return height * width;
        }
        void IControlElement.Close()
        {
            Console.WriteLine("Close rectangle ");
        }

        void IControlElement.Open()
        {
            Console.WriteLine("Open rectangle ");
        }
        public override void resizing()
        {
            Console.WriteLine("Input new height");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input new width");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public override bool Equals(object obj)//
        {
            Rectangle rec = (Rectangle)obj;
            if (this.height == rec.height && this.width == rec.width)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            Random rand = new Random();
            return rand.Next(1, int.MaxValue);
        }

        public override string ToString()
        {
            return "Height: " + height + "\n\rWidth: " + width;
        }

        public override bool DoClone()
        {
            if (Convert.ToBoolean(height))
            {
                return true;
            }
            return false;
        }
        bool IControlElement.DoClone()
        {
            Console.WriteLine("DoClone from Interface ");
            return true;
        }
    }
}
