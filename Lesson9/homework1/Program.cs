// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

string GetEven(int m, int n) {
    if (m % 2 != 0 && m < n) m += 1;
    if (m < 0) m = 2;
    if (m > n) return "";
    else return ($"{m}, " + GetEven(m + 2, n)).TrimEnd(' ', ','); 
}

void result() {
    int m = 15;
    int n = 30;
    System.Console.WriteLine(GetEven(m, n));
}

result();