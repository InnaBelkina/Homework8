// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
Console.WriteLine("Задайте количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);

int sum = 0;
int minSum = 0;
int minRow = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    minSum = minSum + matrix[0, i];
}
// Console.WriteLine(minSum);

for (int j = 1; j < matrix.GetLength(0); j++)
{
    for (int t = 0; t < matrix.GetLength(1); t++)
    {
        sum = sum + matrix[j, t];
    }
    if (minSum > sum)
    {
        minSum = sum;
        minRow = j;
    }
    sum = 0;
}

Console.WriteLine($"Номер строки с минимальной суммой элементов: {minRow+1}");

