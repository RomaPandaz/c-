// Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Пример:
// 4 -> 24 
// 5 -> 120

int Promt(string message) {
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int getfuck(int number) {
    int result = 1;
    for (int i = 1; i <= number; i++) {
        result = result * i;
    }
    return result;
}

int number = Promt("Введите число: ");
int result = getfuck(number);
System.Console.WriteLine($"{number} -> {result}");