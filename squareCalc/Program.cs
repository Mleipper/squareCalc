using System;

namespace squareCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1=helper.getNumber("first");
            var num2=helper.getNumber("Second");
            var num3 = helper.getNumber("Third");
            if (triangle.notValid(num1, num2, num3))
            {
                Console.WriteLine("Invalid Triangle");
            }
            else
            {
                Console.WriteLine($"The area of your triangle is {triangle.calcArea(num1, num2, num3)}");
            }
            
        }
    }

    public class helper {
        public static double getNumber(string time)
        {
            Console.WriteLine($"Please enter {time} number");
            var num =Console.ReadLine();
            if (double.TryParse(num, out double num1))
            {
                Console.WriteLine($"The value of your number is {num1}");
                return num1;
            }
            else
            {
                Console.WriteLine($"{num} is not a number");
                var num2 = helper.getNumber(time);
                return num2;
            }
        }
    }

    public class triangle {
        public static bool notValid(double a, double b, double c)
        {
            return a + b <= c || a + c <= b || c + b <= a;
        }
        public static double calcArea(double length1,double length2, double length3)
        {
            var p = (length1 + length2 + length3) / 2;
            var area = Math.Sqrt((p * (p - length1) * (p - length2) * (p - length3)));
            return area;
        }
    }

}
