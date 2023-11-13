using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;

        if (M <= N)
        {
            for (int i = M; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine("Сумма натуральных чисел от " + M + " до " + N + " равна " + sum);
        }
        else
        {
            Console.WriteLine("M должно быть меньше или равно N.");
        }
    }
}
