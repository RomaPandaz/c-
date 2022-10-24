// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rnd = new Random();
int value = rnd.Next(100,1000);
int num = value;
int num1 = num / 100;
int num2 = Convert.ToInt32(num);
num2 = num2 % 10;
Console.WriteLine($"{value} -> {num1}{num2}");
int result = (num1 * 10 + num2);                //алтернативный способ вывода 
Console.WriteLine($"{value} -> {result}");      //алтернативный способ вывода 