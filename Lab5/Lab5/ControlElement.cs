using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    public interface IControlElement
    {
        void Close();
        void Open();
        bool DoClone();
    }
}
