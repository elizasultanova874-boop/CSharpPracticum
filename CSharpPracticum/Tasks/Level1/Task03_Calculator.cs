using System;
using CSharpPracticum.Common;

namespace CSharpPracticum.Tasks.Level1
{
    public class Task03_Calculator : ITask
    {
        public string Title => "Калькулятор с делением на ноль";

        public string Description => "Принимать два числа и оператор (+, -, *, /), выводить результат. Обработать деление на ноль.";

        public string[] Requirements => new string[]
        {
            "Использовать switch для оператора",
            "Не допускать падения при делении на ноль",
            "Некорректный оператор — вывести сообщение",
            "Ввод чисел через TryParse"
        };

        public void Run()
        {
            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine();

            Console.Write("Введите оператор (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine();

            // Пытаемся превратить текст в числа (TryParse не роняет программу при ошибке)
            if (!double.TryParse(input1, out double num1) || !double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Ошибка: вы ввели не число!");
                return; // выходим из метода
            }

            double result = 0;
            bool isCorrect = true;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: Деление на ноль невозможно!");
                        isCorrect = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    isCorrect = false;
                    break;
            }

            if (isCorrect)
            {
                Console.WriteLine($"Результат: {num1} {op} {num2} = {result}");
            }
        }
    }
}