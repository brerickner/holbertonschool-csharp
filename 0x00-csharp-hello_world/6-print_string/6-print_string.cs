  
using System;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string str = new StringBuilder("Holberton School".Length * 3).Insert(0, "Holberton School", 3).ToString();
        Console.WriteLine(str + "\n" + str.Substring(0,9));
        }
}
