// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример: 0, 7, 8, -2, -2 -> 2
//        -1, -7, 567, 89, 223-> 3

int DigitCount(string message) {
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] WriteArr(int lenArr) {
    int[] tempArray = new int[lenArr];
    for (int i = 0; i < lenArr; i++)
    {
        tempArray[i] = DigitCount("Введите число -> ");
    }
    return tempArray;
}

void printArray(int[] intArray){
    int countDigit = 0;
    for (int i = 0; i < intArray.Length; i++){
        if (intArray[i] > 0)
        {
            countDigit++;
        }
        System.Console.Write($", {intArray[i]}");
    }
    Console.Write($" -> {countDigit}");
}

int count = DigitCount("Введите количество вводимых чисел -> ");
int[] getArray = WriteArr(count);
printArray(getArray);

