// Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Promt(string message) {
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int GetCountSymb(int number) {
    int count = 0, helpNum = Math.Abs(number);
    do {
        count++;
        helpNum /= 10; 
    } while (helpNum > 0);
    return count;
}

int number = Promt("Введите число: ");
int count = GetCountSymb(number);
System.Console.WriteLine($"{number} -> {count}");