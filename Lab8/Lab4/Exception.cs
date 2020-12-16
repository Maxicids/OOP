using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    public class EmptyExceptions : Exception
    {
        private string message;
        public EmptyExceptions(string _message)
        {
            message = _message;
        }
        public void GetInfo()
        {
            Console.WriteLine("EmptyException: " + message +
                "\nin method " + this.TargetSite);
        }
    }
    public class OverFLowExceptions : Exception
    {
        private string message;
        public OverFLowExceptions(string _message)
        {
            message = _message;
        }
        public void GetInfo()
        {
            Console.WriteLine("OverFLowExceptions: " + message +
                "\nin method " + this.TargetSite);
        }
    }
}
