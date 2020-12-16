using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    interface ICollectionType<T> where T : new()
    {
        void Add(T element);
        T Remove();
        void Show();
    }
}
