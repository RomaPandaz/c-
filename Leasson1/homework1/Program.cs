// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//  Пример
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите по очереди два целых числа, после кажого нажимая Enter, в ответ будет выведено наибольшее");
int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = Convert.ToInt32(Console.ReadLine());
int min, max;
if (value1 < value2) {
    min = value1;
    max = value2;
}
else {
    min = value2;
    max = value1;
}
Console.Write("a = ");
Console.Write(value1);
Console.Write(", b = ");
Console.Write(value2);
Console.Write(" -> max = ");
Console.Write(max);
Console.Write(", min = ");
Console.WriteLine(min);