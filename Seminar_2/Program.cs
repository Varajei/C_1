
// int num = new Random().Next(10, 100); // создание рандомного числа
// int num1 = num / 10;
// int num2 = num % 10;

// Console.WriteLine(num);

// if (num1 > num2)
// {
//     Console.WriteLine("num1 > num2");
// }
// else if (num1 < num2)
// {
//     Console.WriteLine("num1 < num2");
// }
// else
// {
//     Console.WriteLine("num1 = num2");
// }

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Clear();
// Console.Write("Введите A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int crat = numberA % numberB;
// if (crat == 0)
// {
//    Console.Write($"Кратно");
// }
// else 
// {
//      Console.Write($"не кратно {crat}");
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Clear();
// Console.Write("Введите A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// if (numberA % 7 == 0 & numberA % 23 == 0) // Логическое И
// {
//    Console.Write($"Кратно");
// }
// else 
// {
//     Console.Write($"не кратно ");
// }

// Напишите программу, которая на вход
// принимает два числа и проверяет, является ли первое
// число квадратом второго.
// a = 5, b = 25 -> да
// a = -4, b = 16 -> нет
// a = 25, b = 5 -> да
// a = 8 b = 9 -> нет

Console.Clear();
Console.Write("Введите номер А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер Б: ");
int numB= Convert.ToInt32(Console.ReadLine());

if(numA==(numB*numB))Console.WriteLine("Является");
else if(numB==(numA*numA))Console.WriteLine("Является");
else Console.WriteLine("Не является");

