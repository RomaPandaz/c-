// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число");
double value = Convert.ToDouble(Console.ReadLine());
if (value % 7 == 0 && value % 23 == 0){
    Console.WriteLine("Число кратно 7 и 23");
}
else{
    Console.WriteLine("не кратно 7 и 23");
}