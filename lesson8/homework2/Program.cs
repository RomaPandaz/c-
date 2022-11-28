// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int getDigit (string msg) { 
    Console.Write(msg); 
    int digit = Convert.ToInt32(Console.ReadLine()); 
    return digit; 
} 

int[,] MakeMartix (int row, int col) { 
    int[,] matrix = new int[row, col]; 
    for (int i = 0; i < row; i++) { 
       for (int j = 0; j < col; j++) { 
            matrix[i, j] = new Random().Next(0,10);
       } 
    } 
    return matrix; 
}

int[] MakeTempArray(int len) { 
    int[] array = new int[len]; 
    for (int i = 0; i < array.Length; i++) { 
        array[i] = new Random().Next(0,10);
    }
    return array;
} 

void PrintMatrix(int[,] matrix) { 
    for (int i = 0; i < matrix.GetLength(0); i++) { 
        for (int j = 0; j < matrix.GetLength(1); j++) { 
            Console.Write($"{matrix[i, j]}\t"); 
        } 
        Console.Write("\n"); 
    }
    Console.WriteLine(); 
}

void PrintArray(int[] array) { 
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}\t"); 
    }
}

int GetSumRow(int[,] matrix) {
    int sum = 0;
    int[] tempArray = MakeTempArray(matrix.GetLength(0)); //создание массива для сумм строк
    int count = 0; // счетчик адреса в массиве для записи суммы строки
    for (int j = 0; j <= matrix.GetLength(0)-1; j++) { // число проходов
        for (int i = 0; i <= matrix.GetLength(1)-1; i++) { //сумма по строке
                sum = sum + matrix[j,i];
        }
        tempArray[count] = sum;
        count = count + 1;
        sum = 0;                //обнуление после перехода на новую строку 
    }
    PrintArray(tempArray);
    int result = 0;
    int q = 0;
    if (tempArray[q]<tempArray[q+1])
    {
        result = q;
    }
    else result = tempArray[q+1];
    Console.WriteLine(result);
    return result;
}



int x = 3; //getDigit("Задайте колличество строк массива: ");
int y = 3; //getDigit("Задайте колличество столбцов массива: ");
int sum = 0;
int[,] temp2 = MakeMartix(x,y);
PrintMatrix(temp2);
GetSumRow(temp2);
// Console.WriteLine(result);