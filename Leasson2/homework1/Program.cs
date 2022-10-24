// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1000 && num >99){
    num = num % 100;
    int digit = Convert.ToInt32(num);
    digit = digit / 10;
    Console.WriteLine(digit);
}
else{
    Console.WriteLine("Введеное число не трехзначное");
}