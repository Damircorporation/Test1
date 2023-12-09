// // Задача 1: Задайте двумерный массив символов (тип char [,]). 
// // Создать строку из символов этого массива.

// char[,] charArray = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };
// string CreateStringFrom2DArray(char[,] array)
// {
//     string result = String.Empty;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result += array[i, j];
//         }
//     }
//     return result;
// }
// string result = CreateStringFrom2DArray(charArray);
// Console.WriteLine(result);



// // Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// // Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.WriteLine("Введите строку: ");
// String? InputString = Console.ReadLine();
// string result = InputString.ToLower();
// Console.WriteLine ($"Итоговая скорректированная строка:{result}");



// // Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Console.WriteLine("Введите строку : ");
// string? InputString = Console.ReadLine(); 
// string reverseInputString = String.Empty;
// for (int i = InputString.Length - 1; i >= 0; i--)
// {
//     reverseInputString += InputString[i]; 
// }
// if (InputString == reverseInputString)
//     Console.WriteLine("Введенная строка является палиндромом.");
// else
//     Console.WriteLine("Введенная строка не является палиндромом.");



// или так 



// Console.WriteLine("Введите строку : ");
// String InputString = Console.ReadLine();
// char[] sym = InputString.ToCharArray();

// static bool IsPalindrom(char[] InputString)
// {
//     for (int i = 0; i < InputString.Length / 2; i++)
//         if (InputString[i] != InputString[InputString.Length - 1 - i])
//             return false;
//     return true;
// }

// if (IsPalindrom(sym))
//     Console.WriteLine("Введеная строка является палиндром");
// else
//     Console.WriteLine("Введеная строка не является палиндром");