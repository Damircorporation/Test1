// // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// // Квадрат в ОБЕ стороны.
// // 5, 25 -> да
// // -4, 16 -> да
// // 25, 5 -> да
// // 8,9 -> нет

// int firstNumber, secondNumber;
// Console.WriteLine("Введите firstNumber");
// firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите secondNumber");
// secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine($"{firstNumber} является квадратом {secondNumber}");
// }
// if (secondNumber == firstNumber * firstNumber)
// {
//     Console.WriteLine($"{secondNumber} является квадратом {firstNumber}");
// }
// else 
// {
//     Console.WriteLine($"числа не являются квадратом друг друга");
// }


// // Напишите программу, которая принимает на вход координаты точки (X и Y), 
// // причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// int x, y;
// Console.WriteLine("Введите число x");
// x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число y");
// y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.WriteLine($" Номер координаты четверти плоскости в которой находиться точка пересечения это 1");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine($" Номер координаты четверти плоскости в которой находиться точка пересечения это 2");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine($" Номер координаты четверти плоскости в которой находиться точка пересечения это 3");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine($" Номер координаты четверти плоскости в которой находиться точка пересечения это 4");
// }



// Напишите программу, которая выводит третью с начала
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int temp = number;
// if (number >= 100)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     Console.WriteLine($"3 цифра от {temp} = {number % 10}");
// }
// else
// {
//     Console.WriteLine("Введенное число не имеет третью цифру");
// }


// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digits = String.Empty; // ""
while (number > 0)
{
    digits = (number % 10).ToString() + "," + digits;
    number /= 10; 
}
Console.WriteLine($"Итого: {digits}");