// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int getDigit(string outMsg){
    Console.WriteLine(outMsg);
    return int.Parse(Console.ReadLine());
}
int x = getDigit("Введите число");
int start = 1;
for (int i = 0; i < x; i++) {
    int value = start * start;
    Console.Write($"{value} ");
    start = start + 1;
}
