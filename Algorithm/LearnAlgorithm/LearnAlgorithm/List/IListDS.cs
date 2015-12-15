using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.List
{
    public interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(T item);
        void Insert(T item, int i);
        T Delete(int i);
        int Locate(T value);
        T this[int i]
        {
            get;
            set;
        }
    }
}
