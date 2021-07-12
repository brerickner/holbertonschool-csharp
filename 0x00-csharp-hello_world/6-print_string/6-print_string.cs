  
using System;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
        // The StringBuilder class creates a mutable string of characters of a certain length in C#.
        // We can then use the StringBuilder.Insert(0, "Holberton School", 3) function to insert the
        // string "Holberton School" and repeat it three times.
        
		string str = new StringBuilder("Holberton School".Length * 3).Insert(0, "Holberton School", 3).ToString();
        Console.WriteLine(str + "\n" + str.Substring(0,9));
        }
}
