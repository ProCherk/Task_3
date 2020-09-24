using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            int a;

            double b;

            long c;

            string variable;

            /*Перевірка на правильність данних для типу int
             Метод TryParse() повертає конвертоване значення змінної у тип який ми вказуємо 
            Правильність виконання перевіряється успішним результатом */
            do
            {
                Console.Write("Введiть змiнну типу int - ");
                variable = Console.ReadLine();

            } while (!int.TryParse(variable, out a));

            /*Перевірка на правильність данних для типу double*/
            do
            {
                Console.Write("\nВведiть змiнну типу double - ");
                variable = Console.ReadLine();
            } while (!double.TryParse(variable, out b));

            /*Перевірка на правильність данних для типу long*/
            do
            {
                Console.Write("\nВведiть змiнну типу long - ");
                variable = Console.ReadLine();
            } while (!long.TryParse(variable, out c));

            Console.WriteLine($"a = {a}; b = {b}; c = {c}.");
        }
    }
}
