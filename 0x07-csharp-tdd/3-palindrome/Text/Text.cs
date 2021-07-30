using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Gets true if string is palindrome
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>returns True if a string is a palindrome or False if it’s not</returns>
        public static bool IsPalindrome(string s)
        {
            string first = s.Substring(0, s.Length / 2);  
            char[] arr   = s.ToCharArray();

            Array.Reverse(arr);

            string temp   = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
