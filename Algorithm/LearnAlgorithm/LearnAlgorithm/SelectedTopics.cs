using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm
{
    public class SelectedTopics
    {
        public string GetLongestCommonSubString(string left, string right, bool isIgnoreCase)
        {
            if (isIgnoreCase == true)
            {
                return GetLongestCommonSubString(left.ToLower(), right.ToLower());
            }
            else
            {
                return "";
            }
        }
        public string GetLongestCommonSubString(string left, string right)
        {
            string result = "";
            string shorterString = left;
            string longerString = right;
            if (left.Length > right.Length)
            {
                shorterString = right;
                longerString = left;
            }
            string subString = "";
            bool isFound = false;
            for (int i = shorterString.Length; i > 0; i--)
            {
                for (int j = 0; j <= shorterString.Length - i; j++)
                {
                    subString = shorterString.Substring(j, i);
                    if (longerString.Contains(subString))
                    {
                        isFound = true;
                        break;
                    }
                }
                if (isFound == true)
                {
                    break;
                }
            }

            if (isFound == true)
            {
                result = subString;
            }
            return result;
        }

        public List<List<int>> GetAllSubList(List<int> input)
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i <= input.Count; i++)
            {
                //List<int> subList = new List<int>();
                for (int j = 0; j <= i; j++)
                { 
                    
                }
                //result.Add(subList);
            }
            return result;
        }
    }
}
