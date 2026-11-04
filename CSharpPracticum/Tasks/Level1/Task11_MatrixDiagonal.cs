using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task11_MatrixDiagonal : ITask
    {
        public string Title => "Диагональ матрицы N×N";
        public string Description => "Найти сумму элементов главной диагонали матрицы N×N.";
        public string[] Requirements => new string[] { "Размер N вводится (мин. 2)", "Заполнение случайными числами", "Сумма без LINQ в одном цикле" };

        public void Run()
        {
            Console.Write("Введите размер матрицы N (минимум 2): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
            {
                Console.WriteLine("Ошибка: нужно ввести целое число >= 2.");
                return;
            }

            Random rnd = new Random();
            int[,] matrix = new int[n, n];

            // Заполняем матрицу случайными числами от 1 до 9
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }

            // Выводим матрицу на экран
            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }

            // Считаем сумму главной диагонали в одном цикле
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i]; // Элемент, где строка = столбец
            }

            Console.WriteLine($"\nСумма главной диагонали: {sum}");
        }
    }
}