using System;
using System.Text;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task12_Palindrome : ITask
    {
        public string Title => "Палиндром (без учёта регистра/пробелов)";
        public string Description => "Проверить, является ли строка палиндромом, игнорируя регистр и пробелы.";
        public string[] Requirements => new string[] { "Игнорировать регистр", "Игнорировать пробелы и знаки", "Без LINQ Reverse" };

        public void Run()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("Ошибка: строка null.");
                return;
            }

            bool isPal = IsPalindrome(input);
            Console.WriteLine($"Строка \"{input}\" — палиндром: {isPal}");
        }

        private bool IsPalindrome(string s)
        {
            // 1. Очищаем строку: оставляем только буквы и цифры, приводим к нижнему регистру
            StringBuilder cleanStr = new StringBuilder();

            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    cleanStr.Append(char.ToLower(c));
                }
            }

            string clean = cleanStr.ToString();

            // 2. Проверяем на палиндром (пустая строка или 1 символ — это палиндром)
            if (clean.Length <= 1) return true;

            // Идем с двух концов к центру
            int left = 0;
            int right = clean.Length - 1;

            while (left < right)
            {
                if (clean[left] != clean[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }
}