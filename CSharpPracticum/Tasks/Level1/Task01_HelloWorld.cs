using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task01_HelloWorld : ITask
    {
        public string Title => "Hello, World + текущая дата";

        public string Description => "Вывести приветствие и текущую дату в формате dd.MM.yyyy.";

        public string[] Requirements => new string[]
        {
            "Использовать Console.WriteLine",
            "Дату получить через DateTime.Now",
            "Вывести две строки"
        };

        public void Run()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Сегодня: {DateTime.Now:dd.MM.yyyy}");
        }
    }
}