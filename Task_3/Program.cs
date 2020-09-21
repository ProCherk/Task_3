using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть змінну типу int");
            Console.Write("a = ");
            do
            {
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Данні введені некоректно");
                    Console.WriteLine("");
                    Console.WriteLine("Введіть змінну типу int");
                    Console.Write("a = ");
                }
            }
            while (true);

            
            Console.WriteLine("Введіть змінну типу double");
            Console.Write("b = ");
            do
            {
                try
                {
                    double b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Данні введені некоректно");
                    Console.WriteLine("");
                    Console.WriteLine("Введіть змінну типу double");
                    Console.Write("b = ");
                }
            }
            while (true);


            Console.WriteLine("Введіть змінну типу long");
            Console.Write("c = ");
            do
            {
                try
                {
                    long c = Convert.ToInt64(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Данні введені некоректно");
                    Console.WriteLine("");
                    Console.WriteLine("Введіть змінну типу long");
                    Console.Write("c = ");
                }
            }
            while (true);
            

             
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
