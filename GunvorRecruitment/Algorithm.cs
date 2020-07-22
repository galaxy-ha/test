using System;
using System.Collections.Generic;

namespace GunvorRecruitment
{
    public class Algorithm
    {
        static class StringHelper
        {
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
        }
       
        public string ReverseEveryOtherWord(string inputString)
        {
             string ReverseString_Rec(string str)
            {
                if (str.Length <= 1) return str;
                else return ReverseString_Rec(str.Substring(1)) + str[0];
            }
            string correctword = "";
            string output = string.Empty;
            List<string> strList = new List<string>();
            int i = 0;
            foreach (char c in inputString)
            {
                
                if (c != ' ' || c == '\0')
                {
                    correctword += c;
                } else
                {
                    strList.Add(correctword);
                    correctword = "";
                }
                
            }
            strList.Add(correctword);
            foreach (string word in strList)
            {
                if (i % 2 == 0)
                {
                    output += (word + " ");
                }
                if (i % 2 != 0)
                {
                    output += StringHelper.ReverseString(word);
                    output += " ";
                }
                i++;
            }
            string res = output.Remove(output.Length - 1, 1);
            return res;
        }
    }
}