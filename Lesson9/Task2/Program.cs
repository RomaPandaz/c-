﻿// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void PrintNumbersMN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Console.WriteLine(m);
    PrintNumbersMN(m + 1, n);
}

int m = 4;
int n = 9;
PrintNumbersMN(m, n);
