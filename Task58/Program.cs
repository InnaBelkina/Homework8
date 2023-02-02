// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
Console.WriteLine("Задайте количество строк первой матрицы:");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов первой матрицы:");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество строк второй матрицы:");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов второй матрицы:");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[rowsA, columnsA];
int[,] matrixB = new int[rowsB, columnsB];
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
FillArray(matrixB);
PrintArray(matrixB);

if (columnsA != rowsB)
{
    Console.WriteLine("Такие матрицы умножить невозможно");
    return;
}

int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
for (int row = 0; row < matrixA.GetLength(0); row++)
{
    for (int column = 0; column < matrixB.GetLength(1); column++)
    {
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            matrixC[row, column] += matrixA[row,k] * matrixB[k, column];
        }        
    }
}
Console.WriteLine();
PrintArray(matrixC);

