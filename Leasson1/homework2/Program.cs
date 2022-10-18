// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Пример
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите по очереди три целых числа, после кажого нажимая Enter, в ответ будет выведено наибольшее");
int value1 = Convert.ToInt32(Console.ReadLine());
int value2 = Convert.ToInt32(Console.ReadLine());
int value3 = Convert.ToInt32(Console.ReadLine());
int max = 9999999;
if (value1 > value2 && value1 > value3){
    max = value1;
}
else if(value2 > value1 && value2 > value3){
    max = value2;
}
else if (value3 > value1 && value3 > value2){
    max = value3;
}
Console.Write(value1);
Console.Write(", ");
Console.Write(value2);
Console.Write(", ");
Console.Write(value3);
Console.Write(" -> ");
Console.Write(max);