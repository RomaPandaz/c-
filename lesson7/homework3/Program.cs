// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            matrix[i, j] = new Random().Next(0,20); 
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
 
int [,] arr = makeDoubleMartix(3,4); 
printMatrix(arr);

void searchInColumn(int[,] matrix) {
    int count = 0;
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count++;
            sum = sum + matrix[i,j];
        }
        double result = sum * 1.0 / count;
        Console.WriteLine(result);    
    }
    // return result;
}

searchInColumn(arr);

// for (int i = 0; i < arr.GetLength(1); i++)
// {
//         Console.WriteLine(searchInColumn(arr));    
// }
