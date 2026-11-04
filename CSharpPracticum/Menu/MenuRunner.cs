using System;
using System.Collections.Generic;
using CSharpPracticum.Common;
using CSharpPracticum.Tasks.Level1;

namespace CSharpPracticum.Menu
{
    public class MenuRunner
    {
        private List<ITask> _level1 = new List<ITask>()
        {
            new Task01_HelloWorld(),
            new Task02_Primitives(),
            new Task03_Calculator(),
            new Task04_EvenOdd(),
            new Task05_MultiplicationTable(),
            new Task06_DigitSum(),
            new Task07_StringReverse(),
            new Task08_FizzBuzz(),
            new Task09_ArrayStats(),
            new Task10_Sorting(),
            new Task11_MatrixDiagonal(),
        };

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Практикум по C# ===");
                Console.WriteLine("1. Уровень 1 — Базовый");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите уровень: ");

                var input = Console.ReadLine();
                if (input == "0" || input == "q") return;

                if (input == "1") ShowLevel("Уровень 1", _level1);
            }
        }

        private void ShowLevel(string name, List<ITask> tasks)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"--- {name} ---");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i].Title}");
                }
                Console.WriteLine("0. Назад");
                Console.Write("Выберите задание: ");

                var input = Console.ReadLine();
                if (input == "0") return;

                if (int.TryParse(input, out int n) && n >= 1 && n <= tasks.Count)
                {
                    Console.Clear();
                    Console.WriteLine($"Задание: {tasks[n - 1].Title}");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine(tasks[n - 1].Description);
                    Console.WriteLine("--------------------------------------------------");

                    tasks[n - 1].Run();

                    Console.WriteLine("\nНажмите Enter для возврата в меню...");
                    Console.ReadLine();
                }
            }
        }
    }
}