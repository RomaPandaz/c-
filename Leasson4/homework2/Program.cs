// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
// Пример:
//         452 -> 11
//         82 -> 10
//         9012 -> 12

int Promt(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Fulya(int number)
{
    int result = 0;
    do
    {
        result = result + number % 10;
        number = number / 10;
    } while (number > 0);
    return result;
}

int number = Promt("Введите число ");
int result = Fulya(number);
Console.WriteLine($"{number} -> {result}");