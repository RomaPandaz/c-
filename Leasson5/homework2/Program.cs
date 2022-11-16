// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

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
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 != 0) {
            sum += array[i];
        } 
    }
    return sum; 
}

int[] arr = NewArray(5, 0, 10);
PrintArray(arr);
Console.WriteLine(fulya(arr));