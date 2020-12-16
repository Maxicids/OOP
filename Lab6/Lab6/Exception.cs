using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
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
    public class NullExceptions : Exception
    {
        private string message;
        public NullExceptions(string _message)
        {
            message = _message;
        }
        public void GetInfo()
        {
            Console.WriteLine("NullExceptions: " + message +
                "\nin method " + this.TargetSite);
        }
    }
    public class ConstructorExceptions : Exception
    {
        private string message;
        public ConstructorExceptions(string _message)
        {
            message = _message;
        }
        public ConstructorExceptions()
        {
            message = "Ctor error";
        }
        public void GetInfo()
        {
            Console.WriteLine("ConstructorExceptions: " + message +
                "\nin method " + this.TargetSite);
        }
    }
}
