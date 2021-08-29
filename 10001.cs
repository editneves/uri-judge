using System;

class URI
{

    static void Main(string[] args)
    {
        string val;
        int a;
        int b;

        val = Console.ReadLine();
        a = Convert.ToInt32(val);

        val = Console.ReadLine();
        b = Convert.ToInt32(val);

        // display the line
        Console.WriteLine("X = {0}", a+b);
    }

}