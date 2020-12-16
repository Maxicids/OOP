using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    static class StringFunc
    {
        static public string deleteSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }
        
        static public string deleteSigns(string str)
        {
            foreach (char ch in str)
            {
                if (ch == '.' || ch == ',' || ch == '!')
                {
                    str = str.Replace(ch.ToString(), string.Empty);
                }
            }
            return str;
        }

        static public string Up(string str)
        {
            return str.ToUpper();
        }
        static public string Low(string str)
        {
            return str.ToLower();
        }
        static public string Add(string str, string toAdd)
        {
            return str + toAdd;
        }
    }
}
