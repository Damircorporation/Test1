// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// static String recursion(int M, int N)
// {
//     // основное условие задачи
//     if (M > N)
//     {
//         // Базовый случай
//         if (M == N)
//         {
//             return M.ToString();
//         }
//         // Шаг рекурсии / рекурсивное условие
//         return M + " " + recursion(M - 1, N);
//     }
//     else
//     {
//         // Базовый случай
//         if (M == N)
//         {
//             return N.ToString();
//         }
//         // Шаг рекурсии / рекурсивное условие
//         return M + " " + recursion(M + 1, N);
//     }
// }
// Console.WriteLine($"Печать чисел от {M} до {N} = {recursion(M, N)}");



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


// Console.WriteLine("Введите число m:");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = int.Parse(Console.ReadLine());
// int result = CalculateAckermann(m, n);
// Console.WriteLine($"Результат функции Аккермана: {result}");

// static int CalculateAckermann(int m, int n)
// {
//     if (m == 0)
//         return n + 1;

//     if (n == 0)
//         return CalculateAckermann(m - 1, 1);

//     return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
// }


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] array = { 1, 2, 3, 4, 5 };
PrintArrayReverse(array, array.Length - 1);

static void PrintArrayReverse(int[] array, int index)
{
    // Проверяем, является ли индекс отрицательным, тогда выходим из рекурсии
    if (index < 0)
        return;
    Console.WriteLine(array[index]);
    // Рекурсивно вызываем функцию для предыдущего индекса в массиве
    PrintArrayReverse(array, index - 1);
}

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(0, 10);
// }
// Console.WriteLine($"[{string.Join(";  ", array)}]");
// // Console.WriteLine ($"[{PrintArrayReverse(array, array.Length - 1)}]");
// PrintArrayReverse(array, index - 1);

// static void PrintArrayReverse(int[] array, int index)
// {
//     // Проверяем, является ли индекс отрицательным, тогда выходим из рекурсии
//     if (index < 0)
//         return;
//     Console.WriteLine(array[index]);
//     // Рекурсивно вызываем функцию для предыдущего индекса в массиве
//     PrintArrayReverse(array, index - 1);
}