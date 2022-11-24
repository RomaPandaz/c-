// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

 
int getDigit (string msg) { 
    Console.Write(msg); 
    int digit = Convert.ToInt32(Console.ReadLine()); 
    return digit; 
} 
 
int[,] makeDoubleMartix (int row, int col) { 
    int[,] matrix = new int[row, col]; 
    for (int i = 0; i < row; i++) { 
       for (int j = 0; j < col; j++) 
       { 
            matrix[i, j] = new Random().Next(0,10); 
       } 
    } 
    return matrix; 
} 
 
void printMatrix(int[,] matrix) { 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            Console.Write($"{matrix[i, j]}\t"); 
        } 
        Console.Write("\n"); 
    } 
}

string validate(int x, int y, int[,] matrix) {
    if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
    {
        string strArray = String.Join("",matrix[x,y]);
        return strArray;
    }
    else {
        return "Числа с таким адресом в массива нет";
    }
}

Console.WriteLine("Сгенерирован двумерный массив массив:");
int [,] arr = makeDoubleMartix(3,4); 
printMatrix(arr);
int x = getDigit("Введите номер строки: ");
int y = getDigit("Введите номер столбца: ");
Console.WriteLine(validate(x,y,arr));