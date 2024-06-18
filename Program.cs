//Task1
using System;
using System.Linq;
//namespace Task1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] names = { "Aytac", "Fidan", "Leman", "Elsun", "A", };
//            int count = 0;

//            foreach (string name in names)
//            {
//                if (name.StartsWith("A"))
//                {
//                    count++;
//                }
//            }

//            Console.WriteLine("Number of names starting with 'A': " + count);
//        }
//    }
//}


//Task2
//namespace Task2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 9, 4, 14, 38, 92, 45, 100 };

//            int max = numbers.Max();
//            int min = numbers.Min();

//            double mean = (max + min) / 2.0;

//            Console.WriteLine("Arithmetic mean of the largest and smallest numbers: " + mean);
//        }
//    }
//}

//Task3


namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a four-digit number:");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        static bool IsPalindrome(int number)
        {
            if (number < 1000 || number > 9999)
            {
                throw new ArgumentException("The number must be four digits.");
            }

            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            return firstDigit == fourthDigit && secondDigit == thirdDigit;
        }
    }
}
