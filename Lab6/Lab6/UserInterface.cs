using Lab6;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public class UserInterface
    {
        public List<Figure> lst = new List<Figure>();

        public void AddtoList(Figure item)
        {
            lst.Add(item);
        }
        public void RemoveFromList(Figure item)
        {
            if (lst.Count == 0)
            {
                throw new EmptyExceptions("You can't delete element from empty list");
            }
            lst.Remove(item);
        }

        public void ShowList()
        {
            foreach(var item in lst)
            {
                Console.WriteLine(item);
            }
        } 
        //public void AllArea()
        //{
        //    int allArea = 0;
        //    foreach (var item in lst)
        //    {
        //        allArea =+ item.Square_s();
        //    }
        //    Console.WriteLine("The summary area of all elements: " + allArea);
        //}
    }
}
