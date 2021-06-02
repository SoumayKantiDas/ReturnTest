using System;

namespace ReturnTest
{
    class ReturnTest
    {
        static double CalculateArea(int r)
        {
           
            double area = r * r * Math.PI;
            return area;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int radious = int.Parse(s);
            Console.WriteLine($"The area is {CalculateArea(radious)}");
           
        }
    }
}
