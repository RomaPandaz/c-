﻿// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintMatrix(int[,] matrix) { 
    for (int i = 0; i < matrix.GetLength(0); i++) { 
        for (int j = 0; j < matrix.GetLength(1); j++) { 
            Console.Write($"{matrix[i, j]}\t"); 
        } 
        Console.Write("\n"); 
    }
    Console.WriteLine(); 
}

int[,] SortInRow(int[,] matrix) {
    for (int row = 0; row < matrix.GetLength(0); row++) {
        for (int i = 0; i < matrix.GetLength(1)-1; i++) {
            for (int j = 0; j < matrix.GetLength(1)-1; j++) {
                if (matrix[row,j] < matrix[row,j+1]) {
                    (matrix[row,j], matrix[row,j+1]) = (matrix[row,j+1], matrix[row,j]);
                }
            }
        }        
    }
    return matrix;
}

int[,] matrix = new int[,]{{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
PrintMatrix(matrix);
SortInRow(matrix);
PrintMatrix(matrix);