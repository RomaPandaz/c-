// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4. 
// 0,5  7    -2   -0,2 
// 1   -3,3   8   -9,9 
// 8    7,8  -7,1  9 
 
int getDigit (string msg) { 
    Console.Write(msg); 
    int digit = Convert.ToInt32(Console.ReadLine()); 
    return digit; 
} 
 
double[,] makeDoubleMartix (int row, int col) { 
    double[,] matrix = new double[row, col]; 
    for (int i = 0; i < row; i++) { 
       for (int j = 0; j < col; j++) 
       { 
            matrix[i, j] = Convert.ToDouble(new Random().Next(0,100)) / 10; 
       } 
    } 
    return matrix; 
} 
 
void printMatrix(double[,] matrix) { 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            Console.Write($"{matrix[i, j]}\t"); 
        } 
        Console.Write("\n"); 
    } 
} 
 
double [,] arr = makeDoubleMartix(getDigit("Введите количество строк: "), getDigit("Введите количество столбцов: ")); 
printMatrix(arr);