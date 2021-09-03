using System;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = byte.Parse(Console.ReadLine());
            var B = byte.Parse(Console.ReadLine());
            var C = byte.Parse(Console.ReadLine());
            var D = byte.Parse(Console.ReadLine());

            var DIFERENCA = ((A * B) - (C * D));
            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
    }
}
