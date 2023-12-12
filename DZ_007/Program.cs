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

Random random = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(10);
}
// Вывод массива на экран в строчном виде
Console.WriteLine("Массив:");
foreach (int num in array)
{
    Console.Write(num + " ");
}
// Вывод массива на экран в строчном виде, начиная с конца
Console.WriteLine("\nМассив в обратном порядке:");
PrintArrayReverse(array, array.Length - 1);

Console.ReadLine();

// Рекурсивная функция для вывода массива в обратном порядке
static void PrintArrayReverse(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReverse(array, index - 1);
    }
}
