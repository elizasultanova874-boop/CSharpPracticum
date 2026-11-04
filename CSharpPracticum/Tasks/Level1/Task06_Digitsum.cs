using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task06_DigitSum : ITask
    {
        public string Title => "Сумма цифр числа (строка + арифметика)";
        public string Description => "Найти сумму цифр введённого числа двумя способами.";
        public string[] Requirements => new string[] { "Способ 1 (строка)", "Способ 2 (арифметика)", "Отрицательные числа — модуль" };

        public void Run()
        {
            Console.Write("Введите целое число: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка: нужно ввести целое число!");
                return;
            }

            // Вызываем оба метода
            int sum1 = SumByString(number);
            int sum2 = SumByMath(number);

            Console.WriteLine($"Способ 1 (строка): сумма цифр числа {number} = {sum1}");
            Console.WriteLine($"Способ 2 (арифметика): сумма цифр числа {number} = {sum2}");
        }

        // Способ 1: через строку
        private int SumByString(int n)
        {
            int absN = Math.Abs(n); // берем модуль
            string str = absN.ToString();
            int sum = 0;

            foreach (char c in str)
            {
                sum += c - '0'; // превращаем символ в число
            }
            return sum;
        }

        // Способ 2: через арифметику
        private int SumByMath(int n)
        {
            int absN = Math.Abs(n);
            int sum = 0;

            while (absN > 0)
            {
                sum += absN % 10; // берем последнюю цифру
                absN /= 10;       // отрезаем её
            }
            return sum;
        }
    }
}