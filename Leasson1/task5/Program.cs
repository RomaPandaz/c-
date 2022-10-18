// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

while (true) {
    Console.WriteLine("Введите число, чтобы получить обратное значение");
    double value = Convert.ToDouble(Console.ReadLine());
    double outValue = 1 / value;
    Console.Write(value);
    Console.Write(" > ");
    Console.WriteLine(outValue); 
}