using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last_dig = number % 10;
        string the_str = $"The last digit of {number} is {last_dig}";
        if (last_dig > 5)
            Console.WriteLine($"{the_str} and is greater than 5");
        else if (last_dig == 0)
            Console.WriteLine($"{the_str} and is 0");
        else 
            Console.WriteLine($"{the_str} and is less than 6 and not 0");
    }
}