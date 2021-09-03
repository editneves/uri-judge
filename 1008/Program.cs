using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = byte.Parse(Console.ReadLine());
            var workedHours = byte.Parse(Console.ReadLine());
            var priceHour = float.Parse(Console.ReadLine());

            var salary = workedHours * priceHour;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine("SALARY = U$ {0:F2}", salary);
        }
    }
}
