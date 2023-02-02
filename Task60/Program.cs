// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int k = 0;
            while (k < matr.GetLength(2))
            {
                int element = new Random().Next(1, 100);
                if (FindElement(matr, element)) continue;
                matr[i, j, k] = element;
                k++;
        }
    }
}

}

   bool FindElement(int[,,] matr, int el)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == el) return true;
            }
        }
    }
    return false;
}

Console.WriteLine("Задайте первый размер трехмерного массива:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте второй размер трехмерного массива:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте третий размер трехмерного массива:");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[x, y, z];
FillArray(matrix);
PrintArray(matrix);

