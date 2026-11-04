using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task02_Primitives : ITask
    {
        public string Title => "Переменные примитивных типов";

        public string Description => "Объявить переменные всех примитивных типов и вывести их значения и типы.";

        public string[] Requirements => new string[]
        {
            "Минимум: int, long, double, float, decimal, bool, char, string",
            "Для каждой переменной вывести значение и GetType().Name",
            "decimal — с суффиксом m, float — с f"
        };

        public void Run()
        {
            int i = 42;
            long l = 9000000000L;
            double d = 3.14;
            float f = 3.14f;
            decimal m = 3.14m;
            bool b = true;
            char c = 'A';
            string s = "Привет";

            Console.WriteLine($"int: {i} ({i.GetType().Name})");
            Console.WriteLine($"long: {l} ({l.GetType().Name})");
            Console.WriteLine($"double: {d} ({d.GetType().Name})");
            Console.WriteLine($"float: {f} ({f.GetType().Name})");
            Console.WriteLine($"decimal: {m} ({m.GetType().Name})");
            Console.WriteLine($"bool: {b} ({b.GetType().Name})");
            Console.WriteLine($"char: {c} ({c.GetType().Name})");
            Console.WriteLine($"string: {s} ({s.GetType().Name})");
        }
    }
}