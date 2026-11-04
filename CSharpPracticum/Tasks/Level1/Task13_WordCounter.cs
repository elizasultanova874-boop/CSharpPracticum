using CSharpPracticum.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task13_WordCounter : ITask
    {
        public string Title => "Счётчик вхождений слов в тексте";
        public string Description => "Посчитать, сколько раз каждое слово встречается в тексте (Dictionary).";
        public string[] Requirements => new string[] { "Dictionary<string, int>", "Разбить по знакам", "Нижний регистр", "Сортировка по убыванию" };

        public void Run()
        {
            // Тестовый текст
            string text = "Привет мир! Привет всем. Мир прекрасен, мир удивителен. Привет!";

            Console.WriteLine($"Исходный текст: {text}\n");

            // Вызываем метод подсчета
            Dictionary<string, int> wordCounts = CountWords(text);

            // Сортируем словарь по убыванию количества
            List < KeyValuePair < string, int>> sortedList = new List<KeyValuePair<string, int>>(wordCounts);
            sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            // Выводим результат
            Console.WriteLine("Результат:");
            foreach (var pair in sortedList)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            // Заменяем знаки пунктуации на пробелы
            StringBuilder cleanText = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsLetterOrDigit(c) || c == ' ')
                    cleanText.Append(c);
                else
                    cleanText.Append(' '); // заменяем знак на пробел
            }

            // Разбиваем на слова по пробелам (убираем пустые)
            string[] words = cleanText.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                string lowerWord = word.ToLower(); // Приводим к нижнему регистру

                if (counts.ContainsKey(lowerWord))
                {
                    counts[lowerWord]++; // Если слово уже есть, увеличиваем счетчик
                }
                else
                {
                    counts[lowerWord] = 1; // Если нет, добавляем со значением 1
                }
            }

            return counts;
        }
    }
}