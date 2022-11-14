// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
// Пример:
//          3, 5 -> 243 (3⁵)
//          2, 4 -> 16

int Promt(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Pow(int A, int B){
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

int A = Promt("Введите число A => ");
int B = Promt("Введите число B => ");

int result = Pow(A,B);
Console.WriteLine($"{A}, {B} -> {result}");