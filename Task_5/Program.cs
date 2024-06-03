using System;

namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            int maxValue;
            int action = 0;

            Random rand = new Random();

            Console.WriteLine("Введите верхний диапозон");

            string inputMaxValue = Console.ReadLine().Trim();

            while (true) 
            {
                if(int.TryParse(inputMaxValue, out maxValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nВведите число, для верхнего диапозона");
                    inputMaxValue = Console.ReadLine().Trim();
                }
            }

            int hiddenNumber = rand.Next(0,maxValue + 1);

            Console.WriteLine($"Компьютер загадал число из выбраного диапозона от 0 до {maxValue} включительно");

            Console.WriteLine("\nПопробуйте его угадать. " +
                              "Если хотите узнать загаданное число оставьте поле пустым ");

            while(true)
            {
                string inputNumber = Console.ReadLine();
                int currentNumber;

                while (true)
                {
                    if (int.TryParse(inputNumber, out currentNumber) || inputNumber == "")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nВведите число");
                        inputNumber = Console.ReadLine();
                    }
                }
                if(inputNumber == "")
                {
                    Console.WriteLine($"Было загадано число {hiddenNumber}");
                    break;
                }

                else if(currentNumber > hiddenNumber) 
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else if(currentNumber < hiddenNumber) 
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
                    Console.WriteLine($"Поздравляю вы угадали!\nБыло потрачено {action} действий");
                    break;
                }
                action++;
            }

            Console.ReadKey();
        }
    }
}
