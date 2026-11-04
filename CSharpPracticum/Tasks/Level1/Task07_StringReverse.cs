using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task07_StringReverse : ITask
    {
        public string Title => "Реверс строки без LINQ";
        public string Description => "Перевернуть введённую строку. Не использовать Array.Reverse и LINQ.";
        public string[] Requirements => new string[] { "Без LINQ", "Цикл for от конца к началу", "Пустая строка и 1 символ работают" };

        public void Run()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ошибка: строка не может быть null.");
                return;
            }

            string reversed = ReverseString(input);
            Console.WriteLine($"Оригинал: {input}");
            Console.WriteLine($"Реверс:   {reversed}");
        }

        private string ReverseString(string s)
        {
            // Если пустая строка или 1 символ, возвращаем как есть
            if (s.Length <= 1)
                return s;

            char[] result = new char[s.Length];

            // Идем циклом от конца к началу
            for (int i = 0; i < s.Length; i++)
            {
                // Берем символ с конца и кладем в начало массива
                result[i] = s[s.Length - 1 - i];
            }

            return new string(result);
        }
    }
}