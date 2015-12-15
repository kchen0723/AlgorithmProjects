using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Container
{
    public class Container<T> : IContainer<T>
    {
        private readonly int m_size;
        private int m_containerPointer;
        T[] m_items;

        public Container(int size)
        {
            this.m_size = size;
            this.m_items = new T[this.m_size];
            this.m_containerPointer = -1;
        }

        public Container()
            : this(100)
        { 
        }

        public int Count
        {
            get { return this.m_containerPointer + 1; }
        }

        public bool IsEmpty
        {
            get { return this.m_containerPointer == -1; }
        }

        public bool IsFull
        {
            get { return this.m_containerPointer == this.m_size - 1; }
        }

        public void Insert(T item)
        {
            if (this.IsFull)
            {
                throw new ApplicationException("container is full");
            }
            else
            {
                this.m_items[++this.m_containerPointer] = item;
            }
        }

        public void Delete(T item)
        {
            if (this.m_containerPointer >= 0)
            {
                for (int i = 0; i <= this.m_containerPointer; i++)
                {
                    T currentItem = this.m_items[i];
                    if (currentItem.Equals(item))
                    {
                        for (int j = i; j < this.m_containerPointer; j++)
                        {
                            this.m_items[j] = this.m_items[j + 1];
                        }
                        this.m_containerPointer--;
                        break;
                    }
                }
            }
        }
    }
}
