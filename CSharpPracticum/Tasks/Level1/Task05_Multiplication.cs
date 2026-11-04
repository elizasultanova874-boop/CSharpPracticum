using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task05_MultiplicationTable : ITask
    {
        public string Title => "Таблица умножения 10×10";

        public string Description => "Вывести таблицу умножения 10×10 с помощью вложенных циклов for.";

        public string[] Requirements => new string[]
        {
            "Использовать вложенные циклы for",
            "Выровнять столбцы",
            "Заголовки строк/столбцов приветствуются"
        };

        public void Run()
        {
            Console.WriteLine("Таблица умножения 10x10:");
            Console.WriteLine();

            // Внешний цикл — строки (от 1 до 10)
            for (int i = 1; i <= 10; i++)
            {
                // Внутренний цикл — столбцы (от 1 до 10)
                for (int j = 1; j <= 10; j++)
                {
                    // Выводим результат умножения. 
                    // {i * j, 4} означает: вывести число и выделить под него 4 символа (для ровных столбцов)
                    Console.Write($"{i * j,4} ");
                }

                // После каждой строки переходим на новую
                Console.WriteLine();
            }
        }
    }
}