// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Пример
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
int count = 0;
string plus = "value -> ";
while (count < value){
    if (count % 2 == 0){
        plus = (plus + count.ToString() + ", ");
        count = count + 1;
    }
    else{
        count = count + 1; 
    }
}
plus = (plus + value);
Console.WriteLine(plus);