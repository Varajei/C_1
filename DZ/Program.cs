﻿// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число А :");
// string strNum = Console.ReadLine();
// int num = Convert.ToInt32(strNum);

// Console.WriteLine("Введите число Б :");
// string strNum2 = Console.ReadLine();
// int num2 = Convert.ToInt32(strNum2);

// if(num > num2)
// {
//     Console.WriteLine("Число А > Числа Б");
// }
// else if(num < num2)
// {
//     Console.WriteLine("Число А < Числа Б");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число А :");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

Console.WriteLine("Введите число Б :");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);

Console.WriteLine("Введите число B :");
string strNum3 = Console.ReadLine();
int num3 = Convert.ToInt32(strNum3);



if(num > num2){
Console.WriteLine("max1 = num");
}
else if(num < num2);
{
Console.WriteLine("max1 = num2");
}
if(max1 > num3){
Console.WriteLine("max1 = num3");
}
else if(max1 < num3);
{
Console.WriteLine("max1 = MAX");
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число :");
// string strNum = Console.ReadLine();
// int num = Convert.ToInt32(strNum);



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
