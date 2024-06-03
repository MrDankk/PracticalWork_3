using System;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите целое число: ");

            int inputValue;
            string inputText = Console.ReadLine().Trim();

            if(int.TryParse(inputText, out inputValue))
            {
                if(inputValue % 2 == 0)
                {
                    Console.WriteLine("Число чётное");
                }
                else
                {
                    Console.WriteLine("Число не чётное");
                }
            }
            else
            { 
                Console.WriteLine("Не думаю что это число");
            }

            Console.ReadKey();
        }
    }
}
