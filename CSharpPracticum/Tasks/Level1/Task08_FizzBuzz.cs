using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task08_FizzBuzz : ITask
    {
        public string Title => "FizzBuzz 1–100";
        public string Description => "Вывести числа от 1 до 100 с заменами на Fizz, Buzz и FizzBuzz.";
        public string[] Requirements => new string[] { "Кратно 3 -> Fizz", "Кратно 5 -> Buzz", "Кратно 15 -> FizzBuzz", "Сначала проверка на 15" };

        public void Run()
        {
            Console.WriteLine("Запуск FizzBuzz (1-100):\n");

            for (int i = 1; i <= 100; i++)
            {
                // Сначала проверяем на 15 (делится и на 3, и на 5)
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}