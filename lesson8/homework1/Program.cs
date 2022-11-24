// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

void printMatrix(int[,] matrix) { 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            Console.Write($"{matrix[i, j]}\t"); 
        } 
        Console.Write("\n"); 
    }
    Console.WriteLine(); 
} 

int[,] matrix = new int[,]{{1,2,3,4,5}, {0,4,2,9,1}, {2,1,5,7,3},};

printMatrix(matrix);
int count = 0;
while (count<matrix.GetLength(1)) {
for (int i = 0; i < matrix.GetLength(1)-1; i++) {
    if (matrix[0,i]<matrix[0,i+1])
    {
        matrix[0,i] = matrix[0,i+1];
    }
}
count++;    
}

printMatrix(matrix);

// Console.WriteLine(matrix.GetLength(1));
// Console.WriteLine(matrix.GetLength(0));c