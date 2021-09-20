using System;

/*
БЕЗ ЗНАНИЯ ТИПА можно считать так: 
Класс при инициализации принимает в себя максимальное число параметров (сторон/радиуса)
По умолчанию им ставится какое-то сигнальное значние. Если не равно сигнальному, то ориентируемся на число параметров.
*/

namespace AreaLib
{  
    public class Class1
    {
        const double PI = 3.14;

        public Class1()
        {
        }
        /// <summary>
        /// площадь круга
        /// </summary>
        /// <returns></returns>
        public double CircleArea(double radius)
        {
            if (radius > 0)
            {
                return PI * radius * radius;
            }
            return -1;
        }

        protected bool IsCorrectData(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                return false;
            }
            if (a + b <= c || a + c <= b || b + c <= a) //треугольник не существует
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double TriangleArea(double a, double b, double c)
        {
            if (IsCorrectData(a, b, c))
            {
                double half_per = (a + b + c) / 2;
                double area = Math.Sqrt(half_per * (half_per - a) * (half_per - b) * (half_per - c));
                return area;
            }
            return -1;
        }
        
    }
    public class Class2
    {
        public Class2()
        {
        }
        public bool IsPositive(int x) {
            if (x > 0)
            {
                return true;
            }
            else { 
                return false;
            }
        }
    }
}
