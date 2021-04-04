using System;
using AreaLib;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 my = new Class1();
            double ans = my.CircleArea(1);
            Console.WriteLine("" + ans);
            double ans2 = my.TriangleArea(1, 1, 1);
            Console.WriteLine("" + ans2);
        }
    }
}
