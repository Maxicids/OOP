using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab4
{
    class StatisticOperation
    {
        //public static T getMax(T[] stack)
        //{
        //    T sum;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        sum += stack.items[i];
        //    }
        //    return x;
        //}
        //public static int getMin(List obj)
        //{
        //    int x = 0;
        //    for (int i = 0; i < 9; i++)
        //    {
        //        if (obj[i + 1] > obj[i])
        //        {
        //            x = obj[i];
        //        }
        //    }
        //    return x;
        //}
        //public static int Sum(object stack)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        //sum += stack
        //    }
        //    return sum;
        //}
        public static string[] GetFromFile(StreamReader reader)
        {
            string temp = reader.ReadLine();
            return temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
