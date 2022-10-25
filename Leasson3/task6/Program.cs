// Напишите программу, которая генерирует последовательность случайных чисел до тех пор, пока не сгенерирует кратное число введенному в начале.

int getDigit(string msg){
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int digit = getDigit("Введите число");
int temp = 0;
do
{
    int gen = new Random().Next(1, 99); //ограницил диапозон генерируемых чисел для проверки работы
    temp = gen;                         //напрямую указать в условии gen нельзя, пришлось использовать прокладку
    Console.Write($"{gen} ");
} while (digit % temp != 0);