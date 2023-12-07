// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.Write("Введите строку: ");
// int NumberRow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбец: ");
// int NumberColumn = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] res = CreateMatrix(5, 5, 10, 99);
// Console.WriteLine("Исходный массив: ");
// PrintMatrix(res);
// Console.WriteLine();
// if (NumberRow < 0 | NumberRow > res.GetLength(0) - 1 | NumberColumn < 0 | NumberColumn > res.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует  ");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", res[NumberRow, NumberColumn]);
// }



// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] res = CreateMatrix(5, 5, 10, 99);
// Console.WriteLine("Исходный массив: ");
// PrintMatrix(res);
// Console.WriteLine();
// Console.WriteLine("Итоговый массив: ");
// for (int i = 0; i < res.GetLength(0); i++)
// {
//     int tmp = res[4, i];
//     res[4, i] = res[0, i];
//     res[0, i] = tmp;
// }
// PrintMatrix(res);



// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumRowElements(int[,] res, int i)
{
    int sumRow = res[i, 0];
    for (int j = 1; j < res.GetLength(1); j++)
    {
        sumRow += res[i, j];
    }
    return sumRow;
}

int[,] res = CreateMatrix(5, 6, 0, 9);
Console.WriteLine();
Console.WriteLine("Исходный массив: ");
PrintMatrix(res);
int minSumRow = 0;
int sumRow = SumRowElements(res, 0);
for (int i = 1; i < res.GetLength(0); i++)
{
    int tempSumRow = SumRowElements(res, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}
Console.WriteLine($"\nСтрока номер {minSumRow + 1} имеет наименьшую сумму чисел равную {sumRow}");