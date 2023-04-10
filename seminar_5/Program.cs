// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

// int[] GetArray(int size)
// {
//     int[] result = new int [size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//         result[i] = rnd.Next(-9, 10);

//     return result;
// }

// int SumNumPlus(int[] array)
// {
// int result = 0;
// for(int i = 0; i < size; i++)
//     {
//         if(array[i] > 0)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }

// int SumNumMin(int[] array)
// {
// int result = 0;
// for(int i = 0; i < size; i++)
//     {
//         if(array[i] < 0)
//         {
//             result = result + array[i];
//         }
//     }
//     return result;
// }

// // Console.WriteLine($"Сумма положительных чисел: {SumNumPlus(nums)}");
// // Console.WriteLine($"Сумма отрицательных чисел: {SumNumMin(nums)}");

// // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да



// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// int size = 12;
// int[] nums = GetArray(size);
// Console.WriteLine(string.Join("; ", nums));

// int[] GetArray(int size)
// {
//     int[] result = new int [size];
//     Random rnd = new Random();
//     for(int i = 0; i < size; i++)
//         result[i] = rnd.Next(0, 200);

//     return result;
// }

// int NumSum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] < 100)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine($"Количество чисел задоного отрезка от 10 до 99 = {NumSum(nums)}");



// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// int[] FillArray(int length, int minValue, int maxValue)
// {
//     int[] result = new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < length; i++)
//         result[i] = rand.Next(minValue, maxValue + 1);
//     return result;
// }

// Console.Write("Введите три числа (разделитель пробел): ");
// int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

// int[] GetNewArray(int[] array)
// {
//     int size = array.Length % 2 == 0 ? array.Length / 2 : (array.Length / 2) + 1;
//     int[] mult = new int[size];

//     for (int i = 0; i < mult.Length; i++)
//         mult[i] = array[i] * array[array.Length - 1 - i];

//     if (array.Length % 2 == 1) mult[size - 1] = array[array.Length / 2];
//     return mult;
// }


// int[] array = FillArray(5, 0, 10); // 5 это количество элементов массива
// Console.Clear();
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", GetNewArray(array)));


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите основание системы исчисления: ");
// int @base = int.Parse(Console.ReadLine());
// Console.WriteLine(ChangeBase(num, @base));


// string ChangeBase(int num, int @base)
// {
//     int[] array = new int[32];
//     for (int i = 31; ; i--)
//     {
//         array[i] = num % @base;
//         num /= @base;
//         if (num == 0) break;
//     }
//     return String.Join("", array);
// }

// // вариант второй попроще 


// static int setVal()
// {   // ввод числа
//     Console.Write("Введите число : ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// static int[] numToBinar(int num)
// {
//     int[] bin = new int[32];
//     int i = 31;
//     while (num > 0)
//     {
//         bin[i] = num % 2;
//         num /= 2;
//         i--;
//     }
//     return bin;
// }

// static void outputArray(int n, int[] arr)
// {   // вывод массива случайных чисел
//     string text = "[" + string.Join(", ", arr) + "]";
//     Console.WriteLine(text);
// }

// static void Main(string[] str)
// {
//     //int number = setVal();
//     //outputArray(32, numToBinar(number));
//     outputArray(32, numToBinar(setVal()));

// }