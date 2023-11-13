using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Натуральные числа от " + M + " до " + N + ": ");

        for (int i = M; i <= N; i++)
        {
            Console.Write(i);

            if (i < N)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}
