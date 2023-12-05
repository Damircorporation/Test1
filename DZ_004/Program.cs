// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// static void Main()
//     {
//         while (true) // Бесконечный цикл
//         {
//             Console.Write("Введите число или 'q' для выхода: ");
//             string input = Console.ReadLine(); // Чтение строки ввода пользователя
//             if (input == "q") // Проверка на ввод 'q' для выхода
//             {
//                 break;
//             }
//             int number;
//             if (int.TryParse(input, out number)) // Проверка, является ли ввод числом{
//                 int sum = 0;
//             while (number > 0) // Вычисление суммы цифр числа
//             {
//                 sum += number % 10; // Добавление последней цифры к сумме
//                 number /= 10; // Удаление последней цифры из числа
//             }
//             if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
//             {
//                 Console.WriteLine("[STOP]");
//                 break;
//             }
//         }
// else // Если ввод не является числом и не 'q', повторить запрос
//         {
//             Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
//         }
//     }



// Задача №2. Задайте массив заполненный случайными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100, 1000);
// }
// Console.WriteLine($"[{string.Join(";  ", array)}]");
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     if ((array[i] % 2) == 0)
//         count++;
// }
// Console.WriteLine($"Количество четных чисел в массиве: {count}");



// Задача №3. Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

// int size = 10;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(1, 10);
// }
// Console.WriteLine($" Исходный масив [{string.Join(";  ", array)}]");
// for (int i = 0; i < size / 2; i++)
// {
//     int temp = 0;
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }
// Console.WriteLine($" Перевернутый масив: [{string.Join(";  ", array)}]");

// ИЛИ такой вариант

// int[] array = { 1, 3, 5, 6, 7, 8 }; // Исходный массив
// // Вывод исходного массива
// Console.Write("Исходный массив: ");
// foreach (int number in array)
// {
//     Console.Write(number + " ");
// }
// // Реверсирование массива
// for (int i = 0; i < array.Length / 2; i++)
// {
//     // Меняем местами элементы
//     int temp = 0;
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }
// // Вывод измененного массива
// Console.Write("\nПеревернутый массив: ");
// foreach (int number in array)
// {
//     Console.Write(number + " ");
// }
