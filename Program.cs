using System;

namespace Homework_5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подсчет гласных в строке
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            char[] ch = { 'а', 'у', 'е', 'ы', 'о', 'э', 'я', 'и', 'ю', 'У', 'Е', 'Ы', 'А', 'О', 'Э', 'Я', 'И', 'Ю', };
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    if (str[i] == ch[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
