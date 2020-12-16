using System;

namespace Lab4
{
    class Stack<T> where T : IComparable<T>
    {
        private int maxSize;
        private T[] items;
        private int count;

        

        public Stack(int size)
        {
            items = new T[size];
            count = 0;
            maxSize = size;
        }
        public void Push(T newItem)
        {
            if (count == maxSize)
            {
                throw new InvalidOperationException("Stack overflow");
            }
            items[count] = newItem;
            count++;
        }
        private static T value;
        public void Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            items[count] = value;
            count--;
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception("Stack is empty");
            }
            return items[count - 1];
        }
        public void Clear()
        {
            T[] items = new T[maxSize];
            count = 0;
        }
        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.Write("\n");
        }
        public static Stack<T> operator *(Stack<T> stack, T item)
        {
            stack.Push(item);
            return stack;
        }
        public static bool operator ==(Stack<T> stack1, Stack<T> stack2)
        {
            if(stack1.count!=stack2.count)
            {
                return false;
            }
            else
            {
                for(int i = 0; i < stack1.count; i++)
                {
                    if(stack1.items[i].CompareTo(stack2.items[i])!=0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Stack<T> stack1, Stack<T> stack2)
        {
            return !(stack1 == stack2);
        }
        public static Stack<T> operator /(Stack<T> stack, T item)
        {
            for (int i = 0; i < stack.count; i++)
            {
                if (stack.items[i].CompareTo(item) == 0)
                {
                    stack.items[i] = value;
                    stack.count--;
                    for (int j = i; j < stack.count; j++)
                    {
                        stack.items[j] = stack.items[j + 1];
                    }
                }
            }
            return stack;
        }
        public static bool operator true(Stack<T> stack)
        {
            for (int i = 0; i < stack.count; i++)
            {
                if (stack.items[i].CompareTo(value) == -1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator false(Stack<T> stack)
        {
            for (int i = 0; i < stack.count; i++)
            {
                if (stack.items[i].CompareTo(value) == 1)
                {
                    return true;
                }
            }
            return false;
        }
        public class Owner
        {
            int id;
            string name;

            public Owner(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public void Out()
            {
                Console.WriteLine(this.name + this.id);
            }
        }

        public class Date
        {
            int day;
            int month;

            public Date(int day, int month)
            {
                this.day = day;
                this.month = month;
            }

            public void Out()
            {
                Console.WriteLine(this.day + this.month);
            }
        }
    }
}
