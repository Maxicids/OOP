using System;

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
            UserInterface UI = new UserInterface();
            UI.AddtoList(sq1);
            UI.AddtoList(sq);
            UI.AddtoList(square);
            UI.AddtoList(circ);
            UI.ShowList();
            Console.WriteLine(Controller.Area(UI));
        }
    }
}
