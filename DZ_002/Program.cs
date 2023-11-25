int firstNumber, secondNumber;
Console.WriteLine("Введите firstNumber");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите secondNumber");
secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"{firstNumber} является квадратом {secondNumber}");
}
if (secondNumber == firstNumber * firstNumber)
{
    Console.WriteLine($"{secondNumber} является квадратом {firstNumber}");
}
else 
{
    Console.WriteLine($"числа не являются квадратом друг друга");
}



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


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string digits = String.Empty; // ""
// while (number > 0)
// {
//     // 45 => "5" + "  " + "" ="5   "
//     digits = (number % 10).ToString() + "," + digits;
//     number /= 10; // number = number / 10
//     // 45 / 10 = 4
// }
// Console.WriteLine($"Итого: {digits}");