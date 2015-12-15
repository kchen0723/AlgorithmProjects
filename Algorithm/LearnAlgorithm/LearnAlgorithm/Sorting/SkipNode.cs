using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Sorting
{
    public class SkipNode
    {
        public int key;
        public object value;
        public SkipNode[] link;
        public SkipNode(int level, int key, object value)
        {
            this.key = key;
            this.value = value;
            link = new SkipNode[level];
        }
    }
}
