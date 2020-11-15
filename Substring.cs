
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
namespace LongestSubstring
{
   public class Substring
    {
       public static string LengthOfLongestSubstring(string str)  
       {
   
          int i; 
          int n = str.Length; 
          // Starting point of current substring. 
          int st = 0; 
          // length of current substring. 
          int currlen = 0; 
         // maximum length substring without repeating characters. 
          int maxlen = 0; 
         // starting index of maximum length substring. 
          int start = 0; 
         // Hash Map to store last occurrence of each already visited character.
          Dictionary<char, int> pos = new Dictionary<char, int>();
         // Last occurrence of first character is index 0; 
         pos.Add(str[0], 0); 
 
         for (i = 1; i < n; i++) 
           {
            // If this character is not present in hash,then this is first occurrence of this character, store this in hash. 
              if (!pos.ContainsKey(str[i]))
                {
                   pos.Add(str[i], i);
                }
             else
                { 
                 // If this character is present in hash then this character  has previous occurrence,  check if that occurrence is before or after starting  point of current substring. 
                  if (pos[str[i]] >= st) 
                     {
                          // find length of current substring and update maxlen and start accordingly. 
                             currlen = i - st; 
                              if (maxlen < currlen) 
                                  { 
                                       maxlen = currlen; 
                                       start = st; 
                                  } 
                                  // Next substring will start after the last occurrence of current character to avoid its repetition. 
                              st = pos[str[i]] + 1; 
                     } 
                 // Update last occurrence of current character. 
                     pos[str[i]] = i;
                 } 
            } 
           // Compare length of last substring with maxlen and update maxlen and start accordingly. 
           if (maxlen < i - st) 
            { 
               maxlen = i - st; 
               start = st; 
            } 
            // The required longest substring without repeating characters is from str[start]  to str[start+maxlen-1]. 
           return str.Substring(start, maxlen); 
        }
    }
}