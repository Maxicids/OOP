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
            lst.Remove(item);
        }

        public void ShowList()
        {
            foreach(var item in lst)
            {
                Console.WriteLine(item);
            }
        } 
    }
}
