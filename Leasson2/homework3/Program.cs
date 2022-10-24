// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

Console.WriteLine("введите число");
int value = Convert.ToInt32(Console.ReadLine());
int digit = value;
if (value < 100){
    Console.WriteLine("В введенном числе отсутствует третья цифра");
}
else{
    while(digit>999){
        digit = digit / 10;
    }
    digit = digit % 10;
    Console.WriteLine($"{value} -> {digit}");
}