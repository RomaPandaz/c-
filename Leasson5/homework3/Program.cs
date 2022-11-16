// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3, 7.4, 22.3, 2, 78] -> 76

double[] array = new double[] {3, 7.4, 22.3, 2, 78};

void PrintArray(double[] array) {
    for (int i = 0; i < array.Length; i++){
        System.Console.Write($"{array[i]}");
        if (i != array.Length - 1) {
            System.Console.Write(", ");
        }
        else {
            System.Console.Write(" -> ");
        }
    }
}

double SearchDifMaxMin(double[] array) {
double max = array[0];
double min = array[0];
    for (int i = 0; i < array.Length; i++){
        if (min > array[i]) {
            min = array[i];
        }
        if (max < array[i]) {
            max = array[i];
        }
    }
double result = max - min;
Console.Write(result);
return result;
}

// double result = 0;
PrintArray(array);
SearchDifMaxMin(array);
// Console.Write(result);
