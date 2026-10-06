using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = ReadPositiveDecimal("Введите баланс телефона: ", "Баланс должен быть неотрицательным.");
            decimal costPerMinute = ReadPositiveDecimal("Введите стоимость одной минуты: ", "Стоимость минуты должна быть больше нуля.", minValue: 0.0001m);

            int totalMinutes = (int)(balance / costPerMinute);

            Console.WriteLine($"Доступно полных минут: {totalMinutes}");
        }

        static decimal ReadPositiveDecimal(string prompt, string errorMessage, decimal minValue = 0m)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal value) && value >= minValue)
                {
                    return value;
                }
                Console.WriteLine(errorMessage);
            }
        }
    }
}
 
