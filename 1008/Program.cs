using System;

namespace _1008
{
    class Program
    {
        static dynamic Read(Type dest)
        {
            string input = Console.ReadLine();
            return Convert.ChangeType(input, dest);
        }

        static void Main(string[] args)
        {
            var number = Read(typeof(byte));
            var workedHours = Read(typeof(byte));
            var priceHour = Read(typeof(float));

            var salary = workedHours * priceHour;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine("SALARY = U$ {0:F2}", salary);
        }
    }
}
