// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

int input(string msg) {                       //функция, выводящее сообщение 
    System.Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

bool validate(int quarter) {
    if (quarter < 1 || quarter > 4) {
        Console.WriteLine("Нет такой четверти");
        return false;
    }   
    return true;
}

string GetCoord(int quarter) {
    if (quarter == 1) {
        return ("x = 1, y = 1");
    }
      if (quarter == 2) {
        return ("x = -1, y = 1");
    }
      if (quarter == 3) {
        return ("x = -1, y = -1");
    }
    return ("x = 1, y = -1");
}

int quarter = input("Введите номер четверти");
if (validate(quarter)) {
    string value = GetCoord(quarter);
    Console.WriteLine(value);
}