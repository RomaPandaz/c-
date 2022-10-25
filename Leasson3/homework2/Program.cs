// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Пример:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetCoord(string outMsg){
    System.Console.WriteLine(outMsg);
    return double.Parse(Console.ReadLine());
}

double getLength(double x1, double y1, double z1, double x2, double y2, double z2) {   
    double value1 = Math.Pow((x1-x2), 2);
    double value2 = Math.Pow((y1-y2), 2);
    double value3 = Math.Pow((z1-z2), 2);
    return Math.Sqrt(value1 + value2 + value3);
}

double x1 = GetCoord("Введите координату X для точки A");
double y1 = GetCoord("Введите координату Y для точки A");
double z1 = GetCoord("Введите координату Z для точки A");
double x2 = GetCoord("Введите координату X для точки B");
double y2 = GetCoord("Введите координату Y для точки B");
double z2 = GetCoord("Введите координату Z для точки A");

double ultraValue = getLength(x1,y1,z1,x2,y2,z2);
Console.WriteLine(ultraValue);