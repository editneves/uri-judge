using System;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            
             double A;
             double B;
             double C;

             A = double.Parse(Console.ReadLine());
             B = double.Parse(Console.ReadLine());
             C = double.Parse(Console.ReadLine());
            double MEDIA = ((A*2 + B*3 + C*5)/10);

            //Console.WriteLine($"MEDIA = {MEDIA}");
            Console.WriteLine("MEDIA = {0:F1}", MEDIA);
        }
    }
}
