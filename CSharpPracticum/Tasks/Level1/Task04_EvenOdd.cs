using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task04_EvenOdd : ITask
    {
        public string Title => "Чётность числа (два способа)";

        public string Description => "Определить, чётное ли введённое число. Сделать это двумя способами в разных методах.";

        public string[] Requirements => new string[]
        {
            "Способ 1: через остаток от деления % 2 == 0",
            "Способ 2: через тернарный оператор ? :",
            "Оба способа реализовать отдельными методами",
            "Вывести результат обоих способов"
        };

        public void Run()
        {
            Console.Write("Введите целое число: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ошибка: нужно ввести целое число!");
                return;
            }

            // Вызываем оба метода
            string result1 = CheckWithModulo(number);
            string result2 = CheckWithTernary(number);

            Console.WriteLine($"Способ 1 (% 2 == 0): число {number} — {result1}");
            Console.WriteLine($"Способ 2 (? :): число {number} — {result2}");
        }

        // Способ 1: через остаток от деления
        private string CheckWithModulo(int n)
        {
            if (n % 2 == 0)
                return "чётное";
            else
                return "нечётное";
        }

        // Способ 2: через тернарный оператор
        private string CheckWithTernary(int n)
        {
            // Если остаток от деления на 2 равен 0, то "чётное", иначе "нечётное"
            return (n % 2 == 0) ? "чётное" : "нечётное";
        }
    }
}