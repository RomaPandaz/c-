// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("введите число");
int value = Convert.ToInt32(Console.ReadLine());
if (value == 6 || value ==7){
    Console.WriteLine(value);
    Console.WriteLine(" -> да");
}
else{
    Console.WriteLine(value);
    Console.WriteLine(" -> НЕТЬ");
}