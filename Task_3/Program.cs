using System;

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целое число:");
            string inputNumber = Console.ReadLine().Trim();
            int number;
            bool primeNumber = true;

            while (true) 
            {
                if(int.TryParse(inputNumber, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз:");
                    inputNumber = Console.ReadLine().Trim();
                }
            }

            int divider = 1;

            while (divider <= number) 
            {
                if(number % divider == 0)
                {
                    if(divider == 1 || divider == number)
                    {
                        Console.WriteLine($"{number} делится на {divider}");
                    }
                    else
                    {
                        Console.WriteLine($"{number} делится на {divider}");
                        primeNumber = false;
                    }
                }
                divider++;
            }

            if(primeNumber == true)
            {
                Console.WriteLine($"{number} является простым числом");
            }
            else
            {
                Console.WriteLine($"{number} не является простым числом");
            }

            Console.ReadKey();
        }
    }
}
