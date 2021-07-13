using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int last_num = number % 10;
        if (last_num < 0)
            last_num = last_num * -1;
            Console.Write(last_num);
        return(last_num);
    }
}
