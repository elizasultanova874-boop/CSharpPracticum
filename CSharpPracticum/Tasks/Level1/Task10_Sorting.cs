using System;
using System.Diagnostics;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task10_Sorting : ITask
    {
        public string Title => "Сортировка пузырьком + вставками";
        public string Description => "Отсортировать массив двумя алгоритмами и замерить время.";
        public string[] Requirements => new string[] { "BubbleSort", "InsertionSort", "Без LINQ и Array.Sort", "Замер через Stopwatch" };

        public void Run()
        {
            int size = 10000;
            Random rnd = new Random();

            // Создаем два одинаковых массива
            int[] array1 = new int[size];
            int[] array2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                int val = rnd.Next(1, 10000);
                array1[i] = val;
                array2[i] = val;
            }

            // Сортировка пузырьком
            Stopwatch sw = Stopwatch.StartNew();
            BubbleSort(array1);
            sw.Stop();
            Console.WriteLine($"BubbleSort: {sw.ElapsedMilliseconds} мс");

            // Сортировка вставками
            sw.Restart();
            InsertionSort(array2);
            sw.Stop();
            Console.WriteLine($"InsertionSort: {sw.ElapsedMilliseconds} мс");

            // Проверка, что оба массива отсортированы одинаково
            bool isSame = true;
            for (int i = 0; i < size; i++)
            {
                if (array1[i] != array2[i]) { isSame = false; break; }
            }
            Console.WriteLine($"Массивы отсортированы одинаково: {isSame}");
        }

        private void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Меняем местами
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
    }
}