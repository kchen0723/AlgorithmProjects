using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Sorting
{
    public class RandomList
    {
        public static List<int> GetRandomIntList(int length)
        {
            Random rnd = new Random(length);
            List<int> result = new List<int>();
            for (int i = 0; i < length; i++)
            {
                result.Add(rnd.Next(length));
            }
            return result;
        }

        public static int[] GetRandomIntArray(int length)
        {
            return GetRandomIntList(length).ToArray();
        }

        public static int[] GetSortedRandomIntArray(int length)
        {
            int[] ints = RandomList.GetRandomIntArray(length);
            BasicSorting sorting = new BasicSorting();
            return sorting.SelectionSort(ints);
        }

        public static void PrintRandomIntList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i);
                Console.Write(",    ");
            }
            Console.Write("\r\n");
        }

        public static void PrintRandomIntList(int[] list)
        {
            foreach (int i in list)
            {
                Console.Write(i);
                Console.Write(",    ");
            }
            Console.Write("\r\n");
        }

        public static void PrintRandomIntListHeader(int[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.Write(i);
                Console.Write(",    ");
            }
            Console.Write("\r\n");
        }
    }
}
