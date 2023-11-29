// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(0, 101);
// }
// Console.WriteLine($"[{string.Join(";  ", array)}]");
// int count = 0;
// for (int i = 0; i < size; i++)
//     if (array[i] >= 20 && array[i] <= 90)
// {
// count++;
// }
// Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {count}");



// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(0, 101);
// }
// Console.WriteLine($"[{string.Join(";  ", array)}]");
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     if ((array[i] % 2) == 0)
//     count++;
// }
// Console.WriteLine($"Количество четных чисел в массиве: {count}");



// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[]result=new double[10];
// for(int i=0; i>result.lenght; i++)
// {
//     result[i]=Math.Round(new Random().NextDouble()*new Random().Next(1001),2);
// }
// Console.WriteLine($"Результат [{string.join("; ", result)}]");


int size = 10;
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(new Random().NextDouble()*new Random().Next(0, 101),2);
}
Console.WriteLine($"[{string.Join(";  ", array)}]");
double min = 0;
double max = 0;
for (double i = 0; i < size; i++)
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($" Максимальный элемент: {max}, Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");


// Console.WriteLine("Введите размер массива:");
// int n = Convert.ToInt32(Console.ReadLine()); // Задаём размер массива
// int [] mass  = new int[n];      // Создаём массив
// Random rnd = new Random();      // Создание объекта для генерации чисел
// for (int i = 0; i < n; i++)
//     { mass[i] = rnd.Next(-50, 50);  // Заполнение рандомами
//     Console.Write($" {mass[i]} ");
// }
// int min = 0;
// int max = 0;
// foreach (int i in array)  // Поиск максимального и минимального значения
// {
//     if (min > i) min = i;
//     if (max < i) max = i;
// }
// Console.WriteLine($"\n Максимальный элемент: {array}\n Минимальный элемент: {min}");
// Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");