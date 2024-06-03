using System;

namespace Task_4
{
    internal class Program
    {
        static void Main()
        {
            int minValue = int.MaxValue;
            int cycleCount;

            Console.WriteLine("Введите длину последовательности чисел");
            string inputCycleCount = Console.ReadLine().Trim();

            while(true)
            {
                if (int.TryParse(inputCycleCount, out cycleCount))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз");
                    inputCycleCount = Console.ReadLine().Trim();
                }
            }

            for (int i = 0; i < cycleCount; i++) 
            { 
                Console.WriteLine($"\nВведите {i + 1} число:");
                string inputValue = Console.ReadLine().Trim();
                int currentValue;

                if(int.TryParse(inputValue, out currentValue))
                {
                    if(currentValue < minValue)
                    {
                        minValue = currentValue;
                    }
                }
                else
                {
                    Console.WriteLine("Это не похоже на число");
                    i--;
                }
            }
            
            Console.WriteLine($"Минимальное значение из введеных = {minValue}");
            Console.ReadKey();
        }
    }
}
