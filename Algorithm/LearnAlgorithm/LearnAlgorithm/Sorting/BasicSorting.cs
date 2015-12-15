using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Sorting
{
    public class BasicSorting
    {
        public int[] BubbleSort(int[] input)
        {
            int temp;
            RandomList.PrintRandomIntList(input);
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
                RandomList.PrintRandomIntList(input);
            }
            return input;
        }

        public int[] SelectionSort(int[] input)
        {
            int minIndex;
            int temp;
            RandomList.PrintRandomIntList(input);
            for (int i = 0; i < input.Length; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[minIndex] > input[j])
                    {
                        minIndex = j;
                    }
                }
                temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
                RandomList.PrintRandomIntList(input);
            }
            return input;
        }

        public int[] InsertionSort(int[] input)
        {
            int j;
            int temp;
            RandomList.PrintRandomIntList(input);
            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i];
                j = i;
                while (j > 0 && input[j - 1] > temp)
                {
                    input[j] = input[j - 1];
                    j--;
                }
                input[j] = temp;
                RandomList.PrintRandomIntList(input);
            }
            return input;
        }
    }
}
