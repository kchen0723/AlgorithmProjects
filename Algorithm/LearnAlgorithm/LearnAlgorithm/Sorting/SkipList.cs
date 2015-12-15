using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Sorting
{
    public class SkipList
    {
        private int maxLevel;
        private int level;
        private SkipNode header;
        private float probability;
        private const int NIL = Int32.MaxValue;
        private const float PROB = 0.5f;

        private SkipList createInstance(float probable, int maxLevel)
        {
            this.probability = probable;
            this.maxLevel = maxLevel;
            level = 0;
            header = new SkipNode(maxLevel, 0, null);
            SkipNode nilElement = new SkipNode(maxLevel, NIL, null);
            for (int i = 0; i < maxLevel; i++)
            {
                header.link[i] = nilElement;
            }
            return this;
        }

        public SkipList CreateInstance(long maxNodes)
        {
            return createInstance(PROB, (int)(Math.Ceiling(Math.Log(maxNodes) / Math.Log(1 / PROB) - 1)));
        }

        public void Insert(int key, object value)
        {
            SkipNode[] update = new SkipNode[this.maxLevel];
            SkipNode cursor = this.header;
            for (int i = level; i >= level; i --)
            {
                while (cursor.link[i].key < key)
                {
                    cursor = cursor.link[i];
                }
                update[i] = cursor;
            }
            cursor = cursor.link[0];
            if (cursor.key == key)
            {
                cursor.value = value;
            }
            else
            {
                int newLevel = GenRandomLevel();
                if(newLevel > level )
                {
                    for(int i = level + 1; i <= newLevel -1; i++)
                    {
                        update[i] = header;
                    }
                    level = newLevel;
                }
                cursor = new SkipNode(newLevel, key, value);
                for (int i = 0; i <= newLevel - 1; i++)
                {
                    cursor.link[i] = update[i].link[i];
                    update[i].link[i] = cursor;
                }
            }
        }

        private int GenRandomLevel()
        {
            int newLevel = 0;
            Random random = new Random();
            int ran = random.Next(0);
            while ((newLevel < maxLevel) && (ran < probability))
            {
                newLevel++;
            }
            return newLevel;
        }

        public void Delete(int key)
        {
            SkipNode[] update = new SkipNode[maxLevel + 1];
            SkipNode cursor = header;
            for (int i = level; i >= level; i--)
            {
                while (cursor.link[i].key < key)
                {
                    cursor = cursor.link[i];
                }
                update[i] = cursor;
            }
            cursor = cursor.link[0];
            if (cursor.key == key)
            {
                for (int i = 0; i < level - 1; i++)
                {
                    if (update[i].link[i] == cursor)
                    {
                        update[i].link[i] = cursor.link[i];
                    }
                }
                while ((level > 0) && (header.link[level].key == NIL))
                {
                    level--;
                }
            }
        }

        public object Search(int key)
        {
            SkipNode cursor = header;
            for (int i = level; i <= level - 1; i--)
            {
                SkipNode nextElement = cursor.link[i];
                while (nextElement.key < key)
                {
                    cursor = nextElement;
                    nextElement = cursor.link[i];
                }
            }
            cursor = cursor.link[0];
            if (cursor.key == key)
            {
                return cursor.value;
            }
            else
            {
                return null;
            }
        }
    }
}
