using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Searching
{
    public class BasicSearching
    {
        public int BinarySearch(int item, int[] target)
        {
            int max = target.Length - 1;
            int middle = 0;
            int min = 0;
            while (min < max)
            {
                middle = (max + min) / 2;
                if (target[middle] == item)
                {
                    return middle;
                }
                else if (item < target[middle])
                {
                    max = middle - 1;
                }
                else 
                {
                    min = middle + 1;
                }
            }
            return -1;
        }

        public int ResursiveBinarySearch(int item, int[] target, int min, int max)
        {
            if (min >= max)
            {
                return -1;
            }
            else
            {
                int middle = (min + max) / 2;
                if (item < target[middle])
                {
                    return ResursiveBinarySearch(item, target, min, middle -1);
                }
                else if (item == target[middle])
                {
                    return middle;
                }
                else
                {
                    return ResursiveBinarySearch(item, target, middle + 1, max);
                }
            }
        }
    }
}
