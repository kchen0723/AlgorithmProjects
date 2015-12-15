using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Tree
{
    public class BinaryTree<T>
    {
        private Node<T> _head;

        public Node<T> Head
        {
            get { return this._head; }
            set { this._head = value; }
        }

        public BinaryTree()
        { 
        }

        public BinaryTree(T data)
        {
            this._head = new Node<T>(data);
        }

        public Node<T> Root()
        {
            return this._head;
        }

        public Node<T> InsertL(T data, Node<T> p)
        {
            Node<T> tmp = new Node<T>(data);
            tmp.LChild = p.LChild;
            p.LChild = tmp;
            return tmp;
        }

        public Node<T> InsertR(T data, Node<T> p)
        {
            Node<T> tmp = new Node<T>(data);
            tmp.RChild = p.RChild;
            p.RChild = tmp;
            return tmp;
        }

        public Node<T> DeleteL(Node<T> p)
        {
            if (p == null || p.LChild == null)
            {
                return null;
            }

            Node<T> result = p.LChild;
            p.LChild = null;
            return result;
        }

        public Node<T> DeleteR(Node<T> p)
        {
            if (p == null || p.RChild == null)
            {
                return null;
            }

            Node<T> result = p.RChild;
            p.RChild = null;
            return result;
        }

        public void PreOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.Data);
            PreOrder(root.LChild);
            PreOrder(root.RChild);
        }

        public void InOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.LChild);
            Console.WriteLine(root.Data);
            InOrder(root.RChild);
        }

        public void PostOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }
            PostOrder(root.LChild);
            PostOrder(root.RChild);
            Console.WriteLine(root.Data);
        }

        public void LevelOrder(Node<T> root)
        {
            if (root == null)
            {
                return;
            }

            Queue<Node<T>> sq = new Queue<Node<T>>();
            sq.Enqueue(root);

            while (sq.Count > 0)
            {
                Node<T> tmp = sq.Dequeue();
                Console.WriteLine(tmp.Data);

                if (tmp.LChild != null)
                {
                    sq.Enqueue(tmp.LChild);
                }
                if (tmp.RChild != null)
                {
                    sq.Enqueue(tmp.RChild);
                }
            }
        }
    }
}
