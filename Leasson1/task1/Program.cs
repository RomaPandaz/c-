﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.WriteLine("Введите число");     //выводим подсказку "введите число" в консоль
string a = Console.ReadLine();      //получаем из консоли введенное с клавиатуры число в виде строки и присваимваем к переменной "a"
string b = Console.ReadLine();      //получаем из консоли введенное с клавиатуры число в виде строки и присваимваем к переменной "b"
int digitA = Convert.ToInt32(a);    //конвертируем строковую переменную "a" в числовое значение и присваеваем к переменной "digitA"
int digitB = Convert.ToInt32(b);    //конвертируем строковую переменную "b" в числовое значение и присваеваем к переменной "digitB"
if ((digitA * digitA) == digitB)    //задаем условие, в котором утверждаем, что квадрат перменной "digitB" равен переменной "digitA"
{
Console.WriteLine("ДА");            //если условие выше верно, то выводится "ДА"
}
else
{
Console.WriteLine("НЕТ");           //если условие выше ложно, то выводится "НЕТ"
}
