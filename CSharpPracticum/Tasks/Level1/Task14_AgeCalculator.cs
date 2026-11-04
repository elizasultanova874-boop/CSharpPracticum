using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task14_AgeCalculator : ITask
    {
        public string Title => "Возраст по дате рождения";
        public string Description => "По дате рождения вычислить точный возраст в годах, месяцах и днях.";
        public string[] Requirements => new string[] { "DateTime.TryParse", "Учесть, наступил ли день рождения", "Обработать ошибку" };

        public void Run()
        {
            Console.Write("Введите дату рождения (например, 15.05.1995): ");
            string input = Console.ReadLine();

            // Пытаемся распарсить дату
            if (!DateTime.TryParse(input, out DateTime birthDate))
            {
                Console.WriteLine("Ошибка: некорректный формат даты!");
                return;
            }

            DateTime today = DateTime.Today;

            // Проверяем, что дата не в будущем
            if (birthDate > today)
            {
                Console.WriteLine("Ошибка: дата рождения не может быть в будущем!");
                return;
            }

            // Вычисляем возраст
            int years = today.Year - birthDate.Year;
            int months = today.Month - birthDate.Month;
            int days = today.Day - birthDate.Day;

            // Корректировка, если день рождения в этом году еще не наступил
            if (days < 0)
            {
                months--;
                // Берем количество дней в предыдущем месяце
                int daysInPrevMonth = DateTime.DaysInMonth(today.Year, today.Month == 1 ? 12 : today.Month - 1);
                days += daysInPrevMonth;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Ваш возраст: {years} лет, {months} месяцев, {days} дней.");
        }
    }
}