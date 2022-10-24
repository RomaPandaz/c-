// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("введите трехзначное число");
double value = Convert.ToDouble(Console.ReadLine());
value = value % 10;
Console.WriteLine(value);