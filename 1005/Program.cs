using System;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
        
             double A;
             double B;
             A = double.Parse(Console.ReadLine());
             B = double.Parse(Console.ReadLine());
        
            double MEDIA = ((A*3.5 + B*7.5)/11);

            //Console.WriteLine($"MEDIA = {MEDIA}");
            Console.WriteLine("MEDIA = {0:F5}", MEDIA);
        }
    }
}
