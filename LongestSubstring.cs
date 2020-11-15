using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace LongestSubstring
{
    public class FindLongestSubString
    {
        public static void Main(String[] args)
        {
            Console.Write("Please Enter your main string : ");
            string mainstring = Console.ReadLine();
            //Substring _substring =new Substring();
         string _substring= Substring.LengthOfLongestSubstring(mainstring);
          Console.WriteLine("Longest substring is :" + _substring);
          int _length=_substring.Length;
          Console.WriteLine("Length of longest substring is :" + _length);
        }
    }
}