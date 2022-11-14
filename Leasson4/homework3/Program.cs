// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
// Пример: 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 -> 8

int[] CreatArray(int len = 8, int min = -9, int max = 10){
    int[] tempArray = new int[len];
    for (int i = 0; i < len; i++){
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

void printArray(int[] intArray){
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++){
        System.Console.Write($", {intArray[i]}");
    }
}

int Promt(string message){
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int len = Promt("Введите размер массива: ");
int min = Promt("Введите минимальное числоэлемента массива : ");
int max = Promt("Введите максимальное число элемента массива : ");

System.Console.Write($"Случайный массив длиной {len} со значениями эллементов от {min} до {max}: ");
printArray(intArray: CreatArray(len, min, max));