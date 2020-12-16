using Lab6;
using System;
using System.Data;
using System.Diagnostics;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle square = new Rectangle();
            square.Height = 10;
            square.Square_s();
            Circle circ = new Circle();
            ((IControlElement)square).Close();

            Rectangle rec = new Rectangle();
            Console.WriteLine("\n" + rec.Equals(square));
            rec = square;
            Console.WriteLine(rec.Equals(square));

            Console.WriteLine("\n" + square.DoClone());
            ((IControlElement)square).DoClone();

            Figure fl, f2;

            fl = new Circle();

            f2 = new Rectangle();

            Square sq = new Square();
            Square sq1 = new Square();

            Printer p = new Printer();
            Figure[] fig = new Figure[4];
            fig[0] = sq;
            fig[1] = square;
            fig[2] = sq1;
            fig[3] = circ;
            for (int i = 0; i < 4; i++)
            {
                p.iAmPrinting(fig[i]);
            }

            sq1.A = 5;
            sq.A = 7;
            circ.Radius = 5;
            //6 lab
            UserInterface UI = new UserInterface();
            UI.AddtoList(sq1);
            UI.AddtoList(sq);
            UI.AddtoList(square);
            UI.AddtoList(circ);
            UI.ShowList();
            Console.WriteLine(Controller.Area(UI));
            Logger logger = new Logger();
            try
            {
                int a = 10;
                int b = 0;
                if (b!=0)
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    
                    throw new NullExceptions("You can't divide by zero");
                }
            }
            catch(NullExceptions exception)
            {
                logger.Log(exception);
                exception.GetInfo();
            }

            try
            {
                UserInterface UI1 = new UserInterface();
                UI1.RemoveFromList(circ);
            }
            catch(EmptyExceptions exception)
            {
                logger.Log(exception);
                exception.GetInfo();
            }

            try
            {
                Rectangle rec100 = new Rectangle(-10);
            }
            catch (ConstructorExceptions exception)
            {
                logger.Log(exception);
                exception.GetInfo();
            }
            finally
            {
                Console.WriteLine("always executed");
            }
            int factorial(int n)
            {
                
                Debug.Assert(n >= 0, "Factorial of negative number does not count");


                Debug.Assert(n <= 10);

                if (n < 2)
                {
                    return 1;
                }

                return factorial(n - 1) * n;
            }

            logger.ShowLog();
            logger.FileLog();
            Console.ReadKey();
            //factorial(-10);
        }
    }
}
