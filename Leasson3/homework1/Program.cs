// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Пример:
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int gitDigit(string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}
bool validDigit(int x){
    if (x > 99999 || x <10000){
        Console.WriteLine("Число не пятизначное");
        return false;
    }
    return true;
}

int value = gitDigit("Введите пятизначное число");

if (validDigit(value)){
int one = value / 10000;
int onePast = value % 10;
int two = value /1000 % 10;
int twoPast = value / 10 % 10;
    if (one == onePast && two == twoPast){
        Console.WriteLine("Палиндром");
    }
    else{
        Console.WriteLine("Не палиндром");
    }
}