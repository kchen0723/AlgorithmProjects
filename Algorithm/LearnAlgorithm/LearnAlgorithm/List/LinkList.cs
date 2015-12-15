using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.List
{
    public class LinkList<T> : IListDS<T>
    {
        private Node<T> _head;

        public Node<T> Head
        {
            get { return this._head; }
            set { this._head = value; }
        }

        public LinkList()
        {
        }

        public int GetLength()
        {
            Node<T> p = this._head;
            int length = 0;
            while (p != null)
            {
                p = p.Next;
                length++;
            }

            return length;
        }

        public void Clear()
        {
            this._head = null;
        }

        public bool IsEmpty()
        {
            return this._head == null;
        }

        public void Append(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (this._head == null)
            {
                this._head = newNode;
                return;
            }

            Node<T> currentItem = this._head;
            while(currentItem.Next != null)
            {
                currentItem = currentItem.Next;
            }
            currentItem.Next = newNode;
        }

        public void Insert(T item, int i)
        {
            Node<T> node = new Node<T>(item);
            Node<T> iNode = this.GetINode(i);
            node.Next = iNode.Next;
            iNode.Next = node;
        }

        public T Delete(int i)
        {
            if (i == 0)
            {
                Node<T> result = this._head;
                this._head = null;
                return result.Data;
            }
            else
            {
                Node<T> previousNode = this.GetINode(i - 1);
                Node<T> iNode = previousNode.Next;
                previousNode.Next = iNode.Next;
                return iNode.Data;
            }

        }

        public int Locate(T value)
        {
            throw new NotImplementedException();
        }

        public T this[int i]
        {
            get
            {
                return this.GetINode(i).Data;
            }
            set
            {
                this.GetINode(i).Data = value;
            }
        }

        private Node<T> GetINode(int i)
        {
            if (i < 0)
            {
                throw new ArgumentNullException("i must not be minus number");
            }
            if (this._head == null)
            {
                throw new NullReferenceException("list is null");
            }

            if (i == 0)
            {
                return this._head;
            }
            else
            {
                Node<T> currentItem = this._head;
                int currentCount = 1;
                while (currentCount <= i && currentItem.Next != null)
                {
                    currentItem = currentItem.Next;
                    currentCount++;
                }
                if (currentCount == i + 1)
                {
                    return currentItem;
                }
                else
                {
                    throw new System.IndexOutOfRangeException("index is out of range");
                }
            }
        }
    }
}
