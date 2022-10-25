// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateCoord(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Точка находится на одной из координат прямых");
        return false;
    }
    return true;
}

int GetQoarter(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }
     if(x < 0 && y > 0)
    {
        return 2;
    }
     if(x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = Promt("Введите X =>");
int y = Promt("Введите Y =>");
if (ValidateCoord(x, y))
{
    int quarter = GetQoarter(x, y);
    System.Console.WriteLine($"Номер четверти = {quarter}");
}