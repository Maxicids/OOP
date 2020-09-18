using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Lab2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();
            //task1();
            //task2();
            //task3();
            task4();
            //task61();
            //Console.WriteLine(task62());


            //string str = "maxidiks";
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length;i++) {
            //    array[i] = rand.Next(0, 10);
            //}
            
            //static Tuple<int, int, int, char> Tuple (int[] array, string str)
            //{
            //    int min, max, sum;
            //    max = min = array[0]; sum = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] < min) min = array[i];
            //        if (array[i] > max) max = array[i];
            //        sum += array[i];
            //    }
            //    return new Tuple<int, int, int, char>(max, min, sum, str[0]);
            //}
            //Console.WriteLine(Tuple(array, str).ToString());
        }
        static void task1()
        {
            //Console.Write("bool = ");
            //bool bl = Convert.ToBoolean(Console.ReadLine());
            //Console.Write("byte = ");//0 to 255
            //byte bt = Convert.ToByte(Console.ReadLine());
            //Console.Write("sbyte = ");//-128 to 127
            //sbyte sbt = Convert.ToSByte(Console.ReadLine());
            //Console.Write("char = ");
            //char ch = Convert.ToChar(Console.ReadLine());
            //Console.Write("decimal = "); //1.2m;
            //decimal dc = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("double = ");
            //double db = Convert.ToDouble(Console.ReadLine());
            //Console.Write("float = ");//1.45f cуффиксы
            //float fl = Convert.ToSingle(Console.ReadLine());
            //Console.Write("int = ");//-2,147,483,648 to 2,147,483,647
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("uint = ");//0 to 4,294,967,295 4 байт
            //uint uNum = Convert.ToUInt32(Console.ReadLine());
            //Console.Write("long = ");//8 байт
            //long longNum = Convert.ToInt64(Console.ReadLine());
            //Console.Write("ulong = ");//0 to 18,446,744,073,709,551,615 8 байт
            //ulong uLongNum = Convert.ToUInt64(Console.ReadLine());
            //Console.Write("short = ");//2 байта -32,768 to 32,767
            //short shortNum = Convert.ToInt16(Console.ReadLine());
            //Console.Write("ushort = ");// 2 байта 0 to 65,535
            //ushort uShortNum = Convert.ToUInt16(Console.ReadLine());
            //Console.Write("string = ");
            //string stringNum = Console.ReadLine();
            //Console.Write("dynamic = ");
            //dynamic dn = Console.ReadLine();


            //Console.WriteLine($"\n\nbool = {bl} \nbyte = {bt} \nsbyte = {sbt}   \ndecimal = {dc} \ndecimal = {ch}" +
            //    $"\ndouble = {db} \nfloat = {fl} \nint = {num} \nuint = {uNum} \nlong = {longNum} " +
            //    $"\nulong = {uLongNum} \nshort = {shortNum} \nushort = {uShortNum} \nstring = {stringNum}" +
            //    $"\ndynamic = {dn}");

            //long var1 = Convert.ToInt64(num);
            //int var2 = Convert.ToInt32(db);
            //ushort var3 = Convert.ToUInt16(bt);
            //double var4 = Convert.ToDouble(fl);
            //uint var5 = Convert.ToUInt32(num);

            //double var6 = fl;
            //int var7 = uShortNum;
            //long var8 = num;
            //short var9 = bt;
            //ulong var10 = uShortNum;

            //Упаковкой (boxing) называется процесс преобразования типазначения в тип System.Object
            //распаковка (unboxing)получение указателя на исходный значимый тип (поля данных), содержащийся в объекте

            int num1 = 10;
            object box = num1;   // упаковка
            long num2 = (long)(int)box; // распаковка

            float floatNumber = 1.4f;
            box = floatNumber;
            float str2 = (float)box;
            Console.WriteLine(num2);

            //MyStruct ms = new MyStruct()

            var Var1 = 10;
            var Var2 = "maxicids";
            //Var2=Var1
            Console.WriteLine("Var1: {0}, Var2: {1}", Var1, Var2);

            System.Nullable<int> nullVar1 = 9;
            if (nullVar1.HasValue)
            {
                Console.WriteLine("nullVar1 has value {0}", nullVar1);
            }
            else
            {
                Console.WriteLine("nullVar1 has value null");
            }

            int? nullVar2 = null;
            if (nullVar2.HasValue)
            {
                Console.WriteLine("nullVar1 has value {0}", nullVar1);
            }
            else
            {
                Console.WriteLine("nullVar1 has value null");
            }
        }



        static void task2()
        {
            Console.WriteLine("\n\nЗадание №2\n");

            string str1 = "Макс";
            string str2 = "Лиза";

            if (String.Compare(str1, str2) < 0)
            {
                Console.WriteLine("Строка str1 стоит перед str2");
            }
            else if (String.Compare(str1, str2) > 0)
            {
                Console.WriteLine("Строка str2 стоит перед str1");
            }
            else
            {
                Console.WriteLine("Строки равны");
            }



            // Задание №2b
            Console.WriteLine("\n\n\t\tЗадание №2b\n");

            int s0 = 10;
            string s1 = "Села ";
            string s2 = "муха ";
            string s3 = "на варенье";


            Console.WriteLine(String.Concat(String.Concat(s1, s2), s3));//s1 + s2 + s3

            string s4 = String.Copy(s3);
            Console.WriteLine(s4);

            string[] words = { "one", "two", "three" };
            Console.WriteLine(string.Join(", ", words));

            str1 = "Maxicids";
            str1 = str1.Substring(4);//выделение подстроки
            Console.WriteLine(str1);


            string text = "И поэтому все так произошло";

            string[] wordsS4 = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in wordsS4)
            {
                Console.Write($"{ s }, ");
            }

            str1 = "Mакс";
            str2 = "Лиза";

            Console.WriteLine("\n" + str1.Insert(2, str2));
            Console.WriteLine(str1.Remove(1, 2) + "\n");//с какого сколько

            Console.WriteLine("\n\n№2с\n\n");


            //string strSource = "changed";
            //char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
            //    'a', 'r', 'r', 'a', 'y' };
            //Console.WriteLine(destination);

            //strSource.CopyTo(0, destination, 4, strSource.Length);
            //Console.WriteLine(destination);


            //Console.WriteLine($"\n{ s0 } и { s1 }");



            // Задание №2c
            Console.WriteLine("\n\n\t\tЗадание №2c\n");

            string freeStr = "";
            string nullStr = null;
            string Str = "maxicids";

            Console.Write(String.IsNullOrEmpty(freeStr) + "\n");
            Console.Write(String.IsNullOrEmpty(nullStr) + "\n");

            Str = Str.Remove(0, Str.Length);
            Console.Write(String.IsNullOrEmpty(Str) + "\n");



            //Задание №2d

            StringBuilder strBuild = new StringBuilder("Муха на варенье");
            strBuild.Append(" вот и все стихотворение");
            strBuild.Insert(5, "села ");
            //strBuild.Remove(0, 4);
            Console.WriteLine(strBuild);
        }



        static void task3()
        {
            //Задание 3a
            int[,] array1 = new int[4, 4];
            Random rand = new Random();
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    array1[i, j] = rand.Next(0, 10);
                    Console.Write($"  { array1[i, j] }  ");
                }
                Console.WriteLine();
            }

            //задание 3b

            string[] strArray = { "max", "sasha", "liza", "danya", "alex" };
            for (int i = 0; i < strArray.Length;i++)
            {
                Console.Write(strArray[i] + "\t");
            }
            Console.WriteLine($"\nРазмер массива: {strArray.Length}\t");


            Console.Write("\nКакой элемент заменить: ");
            int elemToChange = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nНа что заменить ? ");
            string newElem = Console.ReadLine();

            strArray[elemToChange - 1] = newElem;

            Console.WriteLine("Массив после изменения:\n");
            for (int i = 0; i < strArray.Length; i++) {
                Console.WriteLine(strArray[i]);
            }

            //задание 3c


            int[][] Array2 = new int[3][];//строка стобец
            Array2[0] = new int[2];
            Array2[1] = new int[3];
            Array2[2] = new int[4];

            for (int i = 0; i < Array2.Length; i++) {
                for (int j = 0; j < Array2[i].Length; j++) {
                    Array2[i][j] = rand.Next(0, 100);
                }
            }

            for (int i = 0; i < Array2.Length; i++) {
                for (int j = 0; j < Array2[i].Length; j++) {
                    Console.Write($"{Array2[i][j]} \t");
                }
                Console.WriteLine();
            }

            //задание 3d
            var massive = new[] { "max", "liza", "vlad" };
            var stroka = "stroka";
        }

        static void task4()
        {
            (int, string, char, string, ulong) tuple = (10, "кортеж", '#', "Лукашенко", 156145);

            Console.WriteLine(tuple.ToString());

            Console.WriteLine($"\n{ tuple.Item1 }");
            Console.WriteLine($"\n{ tuple.Item3 }");
            Console.WriteLine($"\n{ tuple.Item4 }");

            //деконструкция кортежа
            var t = ("post office", 3.6);
            (string destination, double distance) = t;
            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            var (Destination, Distance) = t;
            Console.WriteLine($"Distance to {Destination} is {Distance} kilometers.");

            var DEstination = string.Empty;
            var DIstance = 0.0;

            (DEstination, DIstance) = t;
            Console.WriteLine($"Distance to {DEstination} is {DIstance} kilometers.");


            var firstTuple = Tuple.Create(9, 3);
            var secondTuple = Tuple.Create(9, 3);
            var check = EqualityComparer<Tuple<int, int>>.Default;

            if (check.Equals(firstTuple, secondTuple))
            {
                Console.WriteLine("Первый кортеж равен второму");
            }
            else
            {
                Console.WriteLine("Первый кортеж не равен второму");
            }
        }

        static int task61()
        {
            checked
            {
                int maxInt = 2147483647;
                return maxInt*2;
            }
        }
        static int task62()
        {
            unchecked
            {
                int maxInt = 2147483647;
                return maxInt*2;
            }
        }
    }
}
