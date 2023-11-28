// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int size = 10;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 101);
}
Console.WriteLine($"[{string.Join(";  ", array)}]");
for (int i = 0; i < size; i++)
{
    if (array[i] >= 20 && array[i] <= 90) ;
    int count = array[i];
}
Console.WriteLine($"Количество элементов в массиве: + {array}");




// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[]result=new double[10];
// for(int i=0; i>result.lenght; i++)
// {
//     result[i]=Math.Round(new Random().NextDouble()*new Random().Next(1001),2);
// }
// Console.WriteLine($"Результат [{string.join("; ", result)}]");