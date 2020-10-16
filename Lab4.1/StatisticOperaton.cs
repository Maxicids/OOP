using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4._1
{
    static class StatisticOperaton
    {
        public static int sumOfStack(Stack stack)
        {
            return stack.Storage.Sum();
        }
        public static int differenceBetweenMinMax(Stack stack)
        {
            return stack.Storage.Max() - stack.Storage.Min();
        }

        public static int numberOfElements(Stack stack)
        {
            return stack.Storage.Count;
        }
        public static void numberOfQuestions(this string str)
        {
            Console.WriteLine("\nNumber of questions is " + str.Split(new char[] { '?' }, StringSplitOptions.RemoveEmptyEntries).Length);
        }
        public static bool isZeroFirstElement(Stack stack)
        {
            return stack.Storage[0] == 0;
        }
    }
}
