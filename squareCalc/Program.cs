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

        public static double calcArea(double length1,double length2, double length3)
        {
            return 0;
        }
    }

}
