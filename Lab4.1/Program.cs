using System;
using System.Buffers;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(10);
            stack.Push(5);
            stack.Push(8);
            stack.Push(5);
            stack.Push(7);
            stack.Show(stack);
            stack = stack / 10;

            stack.Show(stack);
            stack = stack * 10;
            stack.Show(stack);

            if (stack)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            stack.Push(-5);
            if (stack)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Stack stack1 = new Stack();
            stack1 = stack;
            if (stack1 == stack) {
                Console.WriteLine("Stacks are equal");
            }
            else
            {
                Console.WriteLine("Stacks are unequal");
            }

            string str = "Question1? Question2? edfdsg. Question3?";
            str.numberOfQuestions();

            Console.WriteLine(StatisticOperaton.sumOfStack(stack) + " " + StatisticOperaton.differenceBetweenMinMax(stack) + " " + StatisticOperaton.numberOfElements(stack));
        }
    }
}
