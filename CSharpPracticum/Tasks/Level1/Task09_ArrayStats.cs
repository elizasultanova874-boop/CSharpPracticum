using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task09_ArrayStats : ITask
    {
        public string Title => "Массивы: min/max/sum/avg";
        public string Description => "Найти минимум, максимум, сумму и среднее для массива чисел без LINQ.";
        public string[] Requirements => new string[] { "Без LINQ", "4 отдельных метода", "Обработать пустой массив" };

        public void Run()
        {
            // Создаем массив из 20 случайных чисел от 1 до 100
            Random rnd = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            Console.WriteLine();

            // Вызываем методы
            Console.WriteLine($"Минимум: {FindMin(numbers)}");
            Console.WriteLine($"Максимум: {FindMax(numbers)}");
            Console.WriteLine($"Сумма: {CalculateSum(numbers)}");
            Console.WriteLine($"Среднее: {CalculateAverage(numbers):F2}"); // F2 — 2 знака после запятой
        }

        private int FindMin(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }

        private int FindMax(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }

        private int CalculateSum(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        private double CalculateAverage(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            // Используем наш же метод для суммы
            return (double)CalculateSum(arr) / arr.Length;
        }
    }
}