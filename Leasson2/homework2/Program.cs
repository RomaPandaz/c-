// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rnd = new Random();
int value = rnd.Next(100,1000);
int num = value;
int num1 = num / 100;
double num2 = Convert.ToDouble(num);
num2 = num2 % 10;
Console.Write($"{value} -> {num1}{num2}");