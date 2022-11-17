// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 * x + b1 = k2 * x + b2
// k1 * x -k2 * x = b2 - b1
// x = b2 - b1 / k1-k2
 
double Promt(string message){
   System.Console.Write(message);
   return int.Parse(Console.ReadLine());
}

double b1 = Promt("Введите координату b1: ");
double k1 = Promt("Введите координату k1: ");
double b2 = Promt("Введите координату b2: ");
double k2 = Promt("Введите координату k1: ");

double x = (b2 - b1) / (k1-k2);
double y = k2 * x + b2;

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");