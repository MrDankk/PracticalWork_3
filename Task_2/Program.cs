using System;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте, сколько у вас карт на руках?");

            int currentCardValue = 0;

            int cardCount;
            string inputCardCount = Console.ReadLine().Trim();

            while (true)
            {
                if (int.TryParse(inputCardCount, out cardCount))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Напишите цифрами, пожалуйста");
                    inputCardCount = Console.ReadLine().Trim();
                }
            }

            Console.WriteLine("Введите номинал ваших карт");
            Console.WriteLine("Для картинок следует ввести следующее:" +
                                "\nВалет = J" +
                                "\nДама = Q" +
                                "\nКороль = K"+
                                "\nТуз = T");

            for (int i = 1; i <= cardCount; i++) 
            {
                Console.WriteLine($"Введите номинал {i} карты");

                string inputCard = Console.ReadLine().Trim().ToLower();
                int currentCard;

                if(int.TryParse(inputCard, out currentCard) && currentCard > 0 && currentCard < 10)
                {
                    currentCardValue += currentCard;
                }
                else if( inputCard == "j" || inputCard == "q" || inputCard == "k" || inputCard == "t")
                {
                    currentCardValue += 10;
                }
                else
                {
                    Console.WriteLine("Такого значения нет, попробуйте еще раз");
                    i--;
                }
            }

            Console.WriteLine($"У вас на руках {cardCount} карт и их сумма {currentCardValue}");
            Console.ReadKey();
        }
    }
}
