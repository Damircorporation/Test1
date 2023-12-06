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
int[,] res = CreateMatrix(5, 6, 0, 9);
Console.WriteLine("Исходный массив: ");
PrintMatrix(res);
Console.WriteLine();

// void SumInLines (int[,] res)
// {
    Console.Write("Суммы элементов в каждой строке: ");
    for (int i = 0; i < res.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < res.GetLength(1); j++)
        {
            sum += res[i, j];
        }
        return sum
        // Console.Write($"{sum} ");
    }
// }
// res=SumInLines;


// Функция, считающая сумму элементов в строке
// int SumLine(int[,] int i);
// {
//     int sum = res[i, 0];
//     for (int j = 1; j < res.GetLength(1); j++)
//     {
//         sum += res[i, j];
//     }
//     return sum;
// }

int maxSum = 1;
int sum = SumLine(res, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (sum > SumLine(matrix, i))
    {
        sum = SumLine(matrix, i);
        maxSum = i + 1;
    }
}
Console.WriteLine($"\n Строка c наименьшей суммой элементов:  ");

// hello