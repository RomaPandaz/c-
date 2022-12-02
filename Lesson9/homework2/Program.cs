// Задача 2: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int sum(int m, int n) {
    if (m < 0) m = 1; 
    if (m > n) return 0;
    else return (m + sum(m + 1, n));
}

void result() {
    int m = 15;
    int n = 30;
    System.Console.WriteLine(sum(m, n));
}

result();