// Задача 24: Напишите программу, 
// которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SetNumber(string text ="")
// {
//     Console.Write($"Enter number {text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// int sum = 0;
// int num = SetNumber();
// for (int i = 1; i <= num; i++)
// {
//     sum += i;
// }
// Console.WriteLine ($"Sum = {sum}: ");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Clear ();
// Console.Write("Введите число: ");
// string strNumN = Console.ReadLine();
// int numN = Convert.ToInt32(strNumN);
// int count = 0;

// for ( ; numN != 0; numN /= 10)
// {
//     count++;
// }

// Console.WriteLine(count);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] nums = GetArray();
Console.WriteLine(string.Join("; ", nums));

int[] GetArray()
{
    int[] result = new int [8];
    Random rnd = new Random();
    for(int i = 0; i < 8; i++)
        result[i] = rnd.Next(0, 2);

    return result;
}
