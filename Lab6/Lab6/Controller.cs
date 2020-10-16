using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public static class Controller
    {
        public static int numberOfUI(UserInterface UI)
        {
            return UI.lst.Count;
        }
        public static int Area(UserInterface UI)
        {
            int area = 0;
            foreach (var item in UI.lst)
            {
                area += item.Square_s();
            }
            return area;
        }
    }

}
