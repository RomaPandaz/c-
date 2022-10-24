// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int value = new Random().Next(10, 100);
int first = value / 10;
int second = value % 10;
if (first > second){
    Console.Write(value);
    Console.Write(" -> ");
    Console.Write(first);
}
else{
    Console.Write(value);
    Console.Write(" -> ");
    Console.Write(second);
}