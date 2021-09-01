using System;

class Program
{
    public static void Main(string[] args)
    {
       double pi = 3.14159;
        
        string r = Console.ReadLine();

        double raio = double.Parse(r);
        double area = pi * Math.Pow(raio, 2);
        Console.WriteLine("A={0:F4}", area);
    }
}