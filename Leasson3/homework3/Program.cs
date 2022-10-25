// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Пример:
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

double getDigit(string outMsg){
    Console.WriteLine(outMsg);
    return double.Parse(Console.ReadLine());
}
double x = getDigit("Введите число");
double start = 1;
for (double i = 0; i < x; i++) {
    double value = Math.Pow(start, 3);
    Console.Write($"{value} ");
    start = start + 1;
}