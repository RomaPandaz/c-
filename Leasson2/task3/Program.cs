// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.WriteLine("Введите два числа");
double digitA = Convert.ToDouble(Console.ReadLine());
double digitB = Convert.ToDouble(Console.ReadLine());
double div = digitA % digitB;
if (digitA % digitB == 0){
    Console.WriteLine("Второе число кратно первому");
}
else{
    Console.WriteLine(div);
}