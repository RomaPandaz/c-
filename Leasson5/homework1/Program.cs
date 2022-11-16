// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] NewArray(int len = 10, int min = -999, int max = 1000) {
    int[] array = new int[len];
    for (int i = 0; i < len; i++) {
        array[i] = new Random().Next(min,max);
    }
    return array;
}
  
void PrintArray(int[] array) {
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

int fulya(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count++;
        } 
    }
    return count; 
}

int[] arr = NewArray();
PrintArray(arr);
Console.WriteLine(fulya(arr));