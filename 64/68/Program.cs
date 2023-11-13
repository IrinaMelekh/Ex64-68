﻿using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        return -1; // Возврат -1 в случае некорректных входных данных
    }

    static void Main()
    {
        Console.WriteLine("Введите значение m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);

        if (result != -1)
        {
            Console.WriteLine("A(" + m + ", " + n + ") = " + result);
        }
        else
        {
            Console.WriteLine("Некорректные входные данные.");
        }
    }
}