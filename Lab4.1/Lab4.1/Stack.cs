using System;
using System.Collections.Generic;

namespace Lab4._1
{
    class Stack
    {
        private List<int> storage;
        public Owner owner;
        public Date date;
        public class Owner
        {
            int id;
            string name;
            string organization;

            public Owner(int id, string name, string organization)
            {
                this.id = id;
                this.name = name;
                this.organization = organization;
            }
        }
        public class Date
        {
            DateTime dateTime = DateTime.Now;
            public int day;

            public override String ToString()
            {
                return dateTime.ToShortDateString();
            }

        }
        public Stack()
        {
            this.storage = new List<int>();
            this.owner = new Owner(1, "Max", "Maxicids");
            this.date = new Date();
        }

        public List<int> Storage
        {
            get
            {
                return this.storage;
            }
        }

        public int Count
        {
            get
            {
                return this.storage.Count;
            }
        }

        public void Push(int element)
        {
            this.storage.Add(element);
        }

        public void Pop()
        {
            if (this.storage.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            this.storage.RemoveAt(Count - 1);
        }

        public int Peek()
        {
            if (this.storage.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
            return this.storage[this.storage.Count - 1];
        }
        public void Show(Stack stack)
        {
            for (int i =0; i < stack.Count; i++)
            {
                Console.Write(stack.storage[i] + " ");
            }
            Console.Write("\n");
        }

        public static Stack operator *(Stack stack, int element)
        {
            stack.Push(element);
            return stack;
        }
        public static Stack operator /(Stack stack, int item)
        {
            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.storage[i] == item)
                {
                    stack.storage.RemoveAt(i);
                }
            }
            return stack;
        }
        public static bool operator true(Stack stack)
        {
            for (int i = 0; i < stack.Count;i++)
            {
                if (stack.storage[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator false(Stack stack)
        {
            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.storage[i] < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator ==(Stack stack1, Stack stack2)
        {
            if (stack1.Count != stack2.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < stack1.Count; i++)
                {
                    if (stack1.storage[i].CompareTo(stack2.storage[i]) != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Stack stack1, Stack stack2)
        {
            return !(stack1 == stack2);
        }
    }
}
