using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>(10);

            stack.Push("Max");
            stack.Push("Dale");
            stack.Push("Jack");
            stack.Push("Andrew");
            stack.Push("Linda");
            stack.Push("Dale");
            stack.Push("Lisa");
            stack.Show();
            stack.Pop();
            //stack.Show();
            //stack = stack * "Lisa";
            stack.Show();
            stack = stack / "Dale"; //poor Dale
            stack.Show();
            Stack<int> stack1 = new Stack<int>(10);
            stack1.Push(1);
            if(stack1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            stack1.Push(-5);
            if (stack1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Stack<int> stack2 = new Stack<int>(10);
            stack2.Push(1);
            stack2.Push(-5);

            Stack<int> stack3 = new Stack<int>(10);
            stack3.Push(1);

            Console.WriteLine("\n INT EQUAL \n");

            if (stack2 == stack1)
            {
                Console.WriteLine("Equal true");
            }
            else
            {
                Console.WriteLine("Equal false");
            }

            if (stack3 == stack1)
            {
                Console.WriteLine("Equal true");
            }
            else
            {
                Console.WriteLine("Equal false");
            }

            Console.WriteLine("\n STRING EQUAL \n");

            Stack<string> stack4 = new Stack<string>(10);
            stack4.Push("Maks");

            Stack<string> stack5 = new Stack<string>(10);
            stack5.Push("Vlad");

            Stack<string> stack6 = new Stack<string>(10);
            stack6.Push("Maks");

            if (stack4 == stack5)
            {
                Console.WriteLine("Equal true");
            }
            else
            {
                Console.WriteLine("Equal false");
            }

            if (stack4 == stack6)
            {
                Console.WriteLine("Equal true");
            }
            else
            {
                Console.WriteLine("Equal false");
            }

            Console.WriteLine(stack4.GetType());
            
        }
    }
}
