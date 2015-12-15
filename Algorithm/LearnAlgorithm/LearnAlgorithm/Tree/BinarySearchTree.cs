using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Tree
{
    public class BinarySearchTree
    {
        public Node<int> root;
        public BinarySearchTree()
        { 
        }

        public void Insert(int i)
        {
            Node<int> node = new Node<int>(i);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node<int> current = root;
                Node<int> parent;
                while (true)
                {
                    parent = current;
                    if (i <= current.Data)
                    {
                        current = current.LChild;
                        if (current == null)
                        {
                            parent.LChild = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.RChild;
                        if (current == null)
                        {
                            parent.RChild = node;
                            break;
                        }
                    }
                }
            }
        }
    }
}
