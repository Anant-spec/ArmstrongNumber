using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(153));
            Console.WriteLine(IsArmstrong(371));
            Console.WriteLine(IsArmstrong(407));
            Console.WriteLine(IsArmstrong(1634));
            Console.WriteLine(IsArmstrong(8208));
            Console.ReadLine();
        }

        static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int result = 0;
            int n = numberOfDigits(number);

            while (number != 0)
            {
                int remainder = number % 10;
                result += (int)Math.Pow(remainder, n);
                number /= 10;
            }
            return result == originalNumber;
        }

        static int numberOfDigits(int number)
        {
            int count = 0;
            while (number !=0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
    }
}
