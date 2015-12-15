using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.List
{
    public class SequenceList<T> : IListDS<T>
    {
        private readonly int m_size;
        private int m_lastPosition;
        private T[] m_items;

        public SequenceList(int size)
        {
            this.m_size = size;
            this.m_lastPosition = -1;
            this.m_items = new T[this.m_size];
        }

        public SequenceList()
            : this(100)
        { 
        }

        public int GetLength()
        {
            return this.m_lastPosition + 1;
        }

        public void Clear()
        {
            this.m_lastPosition = -1;
        }

        public bool IsEmpty()
        {
            return this.m_lastPosition == -1;
        }

        public bool IsFull()
        {
            return this.m_lastPosition == this.m_size - 1;
        }
        public void Append(T item)
        {
            if (this.IsFull())
            {
                throw new ApplicationException("list is full");
            }
            else
            {
                this.m_items[++this.m_lastPosition] = item;
            }
        }

        public void Insert(T item, int i)
        {
            if (i < 0 || i > this.m_size - 1)
            {
                throw new ApplicationException("i is illegal");
            }
            else
            {
                for (int j = this.m_lastPosition + 1; j > i; j--)
                {
                    this.m_items[j] = this.m_items[j - 1];
                }
                this.m_items[i] = item;
                this.m_lastPosition++;
            }
        }

        public T Delete(int i)
        {
            if (i < 0 || i > this.m_lastPosition)
            {
                throw new ApplicationException(" i is illegal");
            }
            else
            {
                T result = this.m_items[i];
                for (int j = i; j < this.m_lastPosition; j++)
                {
                    this.m_items[j] = this.m_items[j + 1];
                }
                this.m_lastPosition--;
                return result;
            }
        }

        public int Locate(T value)
        {
            for (int i = 0; i < this.m_lastPosition; i++)
            {
                T currentItem = this[i];
                if (currentItem.Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public T this[int i]
        {
            get { return this.m_items[i]; }
            set { this.m_items[i] = value; }
        }
    }
}
