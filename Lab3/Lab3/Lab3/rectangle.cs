using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Lab3
{
    enum Type
    {
        square,
        rectangle,
        rhombus,
        random
    }

    class Rectangle//класс всегда имеет конструктор по умолчанию
    {
        private int height = 1;

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

        private int width = 1;//по умолчанию private

        public int Width
        {
            get { return width; }
            set
            {
                if ((value >= 0) && (value <= 50))
                {
                    width = value;
                }
            }
        }

        private bool bl;
        public bool Bl { get => bl; private set => bl = value; }//инкапсуляция для того чтобы получить доступ к переменным через get set 

        

        static private int numberOfRec = 0;
        public readonly int id;

        Type type;

        public string printWidth()
        {
            return "Width is " + Convert.ToString(width);
        }

        public string printHeight()
        {
            return "Height is " + Convert.ToString(height);
        }

        public string printObj()
        {
            string str = "";
            if (type == Type.square)
            {
                str = "Square";
            }
            else if (type == Type.rectangle)
            {
                str = "Rectangle";
            }
            else if (type == Type.rhombus)
            {
                str = "Rhombus";
            }
            else if (type == Type.random)
            {
                str = "Random";
            }
            return str + " has height: " + height + " and width: " + width;
        }

        public void status(ref int height, ref int width, out int semiPerimeter)//ref по ссылке, out = return
        {
            semiPerimeter = height + width;
        }
        public int area()
        {
            return height * width;
        }

        public void perimeter()
        {
            Console.WriteLine($"The perimeter of a rectangle is {2 * height + 2 * width}");
        }

        static public void numberOfRectangles(Rectangle[] rectangles)
        {
            //foreach (int i in rectangles)
            //{}??
            int numberOfSquares = 0;
            int maxSquaresArea = 0;
            int numberOfRectangles = 0;
            int maxRectanglesArea = 0;
            int numberOfRhombus = 0;
            int maxRhombusArea = 0;
            int numberOfRandoms = 0;
            int maxRandomsArea = 0;
            for (int i = 0; i< rectangles.Length;i++)
            {
                if (rectangles[i].type == Type.square)
                {
                    numberOfSquares++;
                    if (maxSquaresArea < rectangles[i].area())
                    {
                        maxSquaresArea = rectangles[i].area();
                    }
                }
                if (rectangles[i].type == Type.rectangle)
                {
                    numberOfRectangles++;
                    if (maxRectanglesArea < rectangles[i].area())
                    {
                        maxRectanglesArea = rectangles[i].area();
                    }
                }
                if (rectangles[i].type == Type.rhombus)
                {
                    numberOfRhombus++;
                    if (maxRhombusArea < rectangles[i].area())
                    {
                        maxRhombusArea = rectangles[i].area();
                    }
                }
                if (rectangles[i].type == Type.random)
                {
                    numberOfRandoms++;
                    if (maxRandomsArea < rectangles[i].area())
                    {
                        maxRandomsArea = rectangles[i].area();
                    }
                }
            }
            Console.WriteLine("Number of squares: " + numberOfSquares + " with max area: " + maxSquaresArea +
                "\n\rNumber of rectangles: " + numberOfRectangles + " with max area: " + maxRectanglesArea +
                "\n\rNumber of rectangles: " + numberOfRhombus + " with max area: " + maxRhombusArea +
                "\n\rNumber of random: " + numberOfRandoms + " with max area: " + maxRandomsArea); 
        }

        public override bool Equals(object obj)//
        {
            Rectangle rec = (Rectangle)obj;
            if (this.height == rec.height && this.width == rec.width )
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



        public Rectangle()
        {
            this.height = 2;
            this.width = 2;
            this.type = Type.random;
            numberOfRec++;
            id = numberOfRec;
        }

        public Rectangle(int height, int width, Type type)
        {
            this.height = height;
            this.width = width;
            this.type = type;
            numberOfRec++;
            id = numberOfRec;
        }

        public Rectangle(int height, Type type, int width = 10):this(height)
        {
            this.width = width;
            this.type = type;
            numberOfRec++;
            id = numberOfRec;
        }

        static Rectangle()//как только используется класс, то вызывается статистический конструктор(автоматически)
        {
            Console.WriteLine("Static example");
        }

        private Rectangle(int height)
        {
            this.height = height;
        }

        //Rectangle rectangle = new Rectangle(10);
    }
}
