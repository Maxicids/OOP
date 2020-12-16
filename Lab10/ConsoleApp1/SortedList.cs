using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class SortedList<K, T> : IList<T>
    {
        private readonly IList<T> _list = new List<T>();

        #region Implementation of ICollection<T>

        public int Count => _list.Count;
        
        private List<K> Keys = new List<K>();
        
        public bool IsReadOnly => _list.IsReadOnly;

        

        public void Add(K key, T item)
        {
            //T temp;
            //foreach (T Key in _list.Keys)
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    for (int j = i + 1; j < mas.Length; j++)
            //    {
            //        if (mas[i] > mas[j])
            //        {
            //            temp = mas[i];
            //            mas[i] = mas[j];
            //            mas[j] = temp;
            //        }
            //    }
            //}
            Keys.Add(key);
            _list.Add(item);
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IList<T>

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T this[int index] { get => _list[index]; set => _list[index] = value; }

        #endregion

    }

}
