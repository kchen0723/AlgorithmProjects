using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Sorting
{
    public class AdvancedSorting
    {
        public int maxSize;
        public int currentSize;

        public int[] ShellSort(int[] input)
        {
            RandomList.PrintRandomIntListHeader(input);
            RandomList.PrintRandomIntList(input);
            int i = 0;
            int j = 0;
            int stepLength = 0;
            while (stepLength <= input.Length / 3)
            {
                stepLength = stepLength * 3 + 1;
            }
            while (stepLength > 0)
            {
                for (i = stepLength; i < input.Length; i++)
                {
                    int temp = input[i];
                    j = i;
                    while (j > stepLength - 1 && input[j - stepLength] >= temp)
                    {
                        input[j] = input[j - stepLength];
                        j -= stepLength;
                    }
                    input[j] = temp;
                    RandomList.PrintRandomIntList(input);
                }
                stepLength = (stepLength - 1) / 3;
            }
            RandomList.PrintRandomIntList(input);
            return input;
        }

        public void RecQuickSort(int[] input, int first, int last)
        {
            if ((last - first) <= 0)
            {
                return;
            }
            else
            {
                int pivot = input[last];
                int part = this.partition(input, first, last);
                RecQuickSort(input, first, part - 1);
                RecQuickSort(input, part + 1, last);
            }
        }

        private int partition(int[] input, int first, int last)
        {
            int pivotval = input[first];
            int theFirst = first;
            bool okSide;
            first++;
            do
            {
                okSide = true;
                while (okSide)
                {
                    if (input[first] > pivotval)
                    {
                        okSide = false;
                    }
                    else
                    {
                        first++;
                        okSide = (first <= last);
                    }
                }
                okSide = (first <= last);
                while (okSide)
                {
                    if (input[last] <= pivotval)
                    {
                        okSide = false;
                    }
                    else
                    {
                        last--;
                        okSide = (first <= last);
                        if (first < last)
                        {
                            swap(input, first, last);
                            first++;
                            last--;
                        }
                    }
                }
            } while (first <= last);
            swap(input, theFirst, last);
            return last;
        }

        public void swap(int[] input, int item1, int item2)
        {
            int temp = input[item1];
            input[item1] = input[item2];
            input[item2] = temp;
        }
        //public int[] MergeSort(int[] input)
        //{
        //    return recMergeSort(input, 0, input.Length - 1);
        //}

        private void recMergeSort(int[] input, int lbount, int ubound)
        {
            if (lbount == ubound)
            {
                return;
            }
            else
            {
                int mid = (lbount + ubound) / 2;
                recMergeSort(input, lbount, mid);
                recMergeSort(input, mid + 1, ubound);
                merge(input, lbount, mid + 1, ubound);
            }
        }

        private void merge(int[] input, int lowp, int highp, int ubound)
        {
            
            //int lbound = lowp;
            //int mid = highp - 1;
            //int n = (ubound - lbound) + 1;
            //while ((lowp <= mid) && (highp <= ubound))
            //{ 
            //    if(
            //}
        }

        private Node[] shiftUp(int index, Node[] heapArray)
        {
            int parent = (index - 1) / 2;
            Node bottom = heapArray[index];
            while ((index > 0) && (heapArray[parent].data < bottom.data))
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
            return heapArray;
        }

        private bool Insert(int key, Node[] heapArray)
        {
            if (currentSize == maxSize)
            {
                return false;
            }
            Node newNode = new Node(key);
            heapArray[currentSize] = newNode;
            shiftUp(currentSize, heapArray);
            currentSize++;
            return true;
        }

        private Node Remove(Node[] heapArray)
        {
            Node root = heapArray[0];
            currentSize--;
            heapArray[0] = heapArray[currentSize];
            shiftdown(0, heapArray);
            return root;
        }

        private void shiftdown(int index, Node[] heapArray)
        {
            int largerChild;
            Node top = heapArray[index];
            while (index < (int)(currentSize / 2))
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if ((rightChild < currentSize) && heapArray[leftChild].data < heapArray[rightChild].data)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }
                if (top.data >= heapArray[largerChild].data)
                {
                    break;
                }
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public void QuickSort(List<int> list, int low, int high)
        {
            int i = low;
            int j = high;
            int temp = list[low];
            while (low < high)
            {
                while ((low < high) && (list[high] >= temp))
                {
                    --high;
                }
                list[low] = list[high];
                ++low;
                while ((low < high) && (list[low] <= temp))
                {
                    ++low;
                }
                list[high] = list[low];
                --high;
            }
            RandomList.PrintRandomIntList(list.ToArray());
            list[low] = temp;
            if (i < low - 1)
            {
                QuickSort(list, i, low - 1);
            }
            if (low + 1 < j)
            { 
                QuickSort(list, low + 1, j);
            }
        }
    }
}