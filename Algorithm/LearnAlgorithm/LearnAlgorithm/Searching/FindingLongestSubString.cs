using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Searching
{
    public class FindingLongestSubString
    {
        public static void LCSubstring(string word1, string word2, char[] warr1, char[] warr2, int[,] arr)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            char[] chars1 = word1.ToCharArray();
            char[] chars2 = word2.ToCharArray();
            for(int k = 0; k < len1; k++)
            {
                warr1[k] = chars1[k];
                warr2[k] = chars2[k];
            }
            for (int i = len1 - 1; i >= 0; i--)
            {
                for (int j = len2 - 1; j >= 0; j--)
                {
                    if (warr1[i] == warr2[j])
                    {
                        arr[i, j] = 1 + arr[i + 1, j + 1];
                    }
                    else
                    {
                        arr[i,j] = 0;
                    }
                }
            }
        }

        public static string ShowString(int[,] arr, char[] wordArr)
        {
            string substr = "";
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i, j] > 0)
                    {
                        substr += wordArr[j];
                    }
                }
            }
            return substr;
        }

        public static void DispArray(int[,] arr)
        { 
            for(int row = 0; row <= arr.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= arr.GetUpperBound(1); col++ )
                {
                    Console.Write(arr[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
