// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите число");
string incMessage = Console.ReadLine();
int number;
if (incMessage == "") number = 0;
else number = Convert.ToInt32(incMessage);
if (number < 1 || number > 7) {
    Console.WriteLine("нет такого дня недели");
}
else if (number == 1) {
    Console.WriteLine("Понедельник");
}
else if (number == 2) {
    Console.WriteLine("Вторник");
}
else if (number == 3) {
    Console.WriteLine("Среда");
}
else if (number == 4) {
    Console.WriteLine("Четверг");
}
else if (number == 5) {
    Console.WriteLine("Пятница");
}
else if (number == 6) {
    Console.WriteLine("Суббота");
}
else if (number == 7) {
    Console.WriteLine("Воскресенье");
}