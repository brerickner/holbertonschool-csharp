using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Gets index of the first non-repeating character of a string
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>returns the index of the first non-repeating character of a string</returns>
        public static int UniqueChar(string s)
        {
            Dictionary<char,int>dict = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 1); 
                }
                else
                {
                    dict[s[i]] +=1;
                }
            }
            for (int i = 0; i <s.Length; i++)
            {
                if (dict[s[i]]==1)
                {
                    return (i);
                }
            }
        return (-1);
        }        
    }
}
