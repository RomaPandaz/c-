// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Чтобы определить является ли число четным, введите число");
double value = Convert.ToDouble(Console.ReadLine());
if (value % 2 == 0){
    Console.WriteLine("Четное");
}
else{
    Console.WriteLine("Нечетное");
}
