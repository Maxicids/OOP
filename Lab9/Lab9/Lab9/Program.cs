using System;

namespace Lab9
{
    static class Program
    {
        public delegate void MyDelegate();
        public delegate int Valuedelegate(int i);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = promote;
            myDelegate += fine;
            myDelegate();

            Valuedelegate valuedelegate = new Valuedelegate(MethodValue);
            valuedelegate += MethodValue;
            valuedelegate += MethodValue;
            valuedelegate((new Random()).Next(1, 10));


            Director student = new Director(120, "Student");
            student.Fair += () => Console.WriteLine("Person is faired");
            student.Promote += Student_Promote;
            student.IsFair(100);
            student.IsPromote(150);


            Func<int, int, int> mathDelegate = (x, y) =>
            {
                Console.WriteLine("Add");
                return x + y;
            };

            var result = mathDelegate(5, 2);
            Console.WriteLine(result);

            String str = "Ghb!   dshf sdsd sd  !!,.";
            Console.WriteLine(StringFunc.deleteSpace(str));
            Console.WriteLine(StringFunc.deleteSigns(str));
            Console.WriteLine(StringFunc.Add(str, " Added"));
            Console.WriteLine(StringFunc.Up(str));
        }

        private static void Student_Promote(object sender, EventArgs e)
        {
            if (sender is Director)
            {
                Console.WriteLine(((Director)sender).Name + " has been promoted" + 
                    " ,new salary is " + ((Director)sender).Salary);
            }
        }

        //private static void Student_Fair()
        //{
        //    Console.WriteLine("Person is faired");
        //}

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }
        public static void promote()
        {
            Console.WriteLine("You have been promoted");
        }

        public static void fine()
        {
            Console.WriteLine("You have been fined");
        }
    }
}
