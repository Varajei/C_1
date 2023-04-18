// Решение задач в группах
// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Задаём метод двумерного массива
// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];

//     var rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return array;
// }

// //Вывод матрицы
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// //Метод замены первой строки с последней
// void StringMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             int n = matrix.GetLength(0);
//             int tmp = matrix[0, j];
//             matrix[0, j] = matrix[n-1, j];
//             matrix[n-1, j] = tmp;
//         }
//     }
// }


// int[,] matrix = GetRandomMatrix(5, 5, 0, 9);
// PrintMatrix(matrix);
// Console.WriteLine();
// StringMatrix(matrix);
// PrintMatrix(matrix);


// Второй вариант но с другими условиями 

// using System;
// using System.Globalization;

// public class Example
// {
//    public static void Main()
//    {
//       int nMonths = DateTimeFormatInfo.CurrentInfo.Calendar.GetMonthsInYear(DateTime.Now.Year);
//       int[][] months = new int[nMonths][];

//       // Populate elements with number of days in month.
//       for (int ctr = 0; ctr <= months.GetUpperBound(0); ctr++) {
//          int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, ctr + 1);
//          months[ctr] = new int[daysInMonth] ;
//          for (int ctr2 = 1; ctr2 <= daysInMonth; ctr2++)
//             months[ctr][ctr2 - 1] = ctr2;
//       }

//       foreach (var month in months) {
//          foreach (var day in month)
//             Console.Write("{0} ", day);

//          Console.WriteLine();
//       }
//       Console.WriteLine();

//       Console.WriteLine("About to reverse array.\n");
//       Array.Reverse(months);

//       foreach (var month in months) {
//          foreach (var day in month)
//             Console.Write("{0} ", day);

//          Console.WriteLine();
//       }
//    }
// }

// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


// Start();
// void Start()
// {
//     Console.Clear();
//     int rows = SetNumber("rows");
//     int columns = SetNumber("columns");
//     int min = SetNumber("min");
//     int max = SetNumber("max");
//     Console.WriteLine();
//     int[,] matrix = GetRandomMatrix(rows, columns, min, max);
//     PrintMatrix(matrix);
//     Console.WriteLine();
//     int[,] newMatrix = ConvertRowsToColumn(matrix);
//     PrintMatrix(newMatrix);
//     Console.WriteLine();
// }

// int SetNumber(string text = "")
// {
//     Console.Write($"Enter number {text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];
//     var rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return array;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLongLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}   ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ConvertRowsToColumn(int[,] arr)
// {
//     int[,] arr2 = new int[arr.GetLength(1), arr.GetLength(0)];
//     for (int i = 0; i < arr.GetLength(1); i++)
//     {
//         for (int j = 0; j < arr.GetLength(0); j++)
//         {
//             arr2[i, j] = arr[j, i];
//         }
//     }
//     return arr2;
// }

// вариант

// int[,] nums = new int[3, 3];
// Random rnd = new Random();
// int[,] array = new int[3, 3];
// for (int i = 0; i < nums.GetLength(0); i++)
// {
//     for (int j = 0; j < nums.GetLength(1); j++)
//     {
//         nums[i, j] = rnd.Next(21);
//         Console.Write(nums[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// for (int i = 0; i < nums.GetLength(0); i++)
// {
//     for (int j = 0; j < nums.GetLength(1); j++)
//     {
//         array[i, j] = nums[i, j];
//     }
// }
// for (int i = 0; i < 1; i++)
// {
//     array[i, 0] = nums[0, i];
//     array[i, 1] = nums[1, i];
//     array[i, 2] = nums[2, i];
// }
// for (int i = 1; i < 2; i++)
// {
//     array[i, 0] = nums[0, i];
//     array[i, 1] = nums[1, i];
//     array[i, 2] = nums[2, i];
// }
// for (int i = 2; i < 3; i++)
// {
//     array[i, 0] = nums[0, i];
//     array[i, 1] = nums[1, i];
//     array[i, 2] = nums[2, i];
// }
// Console.WriteLine("Результат: ");
// for (int i = 0; i < nums.GetLength(0); i++)
// {
//     for (int j = 0; j < nums.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine();
// }



// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[] rowAr=GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ",rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int index=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if(inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintData(int[] inArray)
{
    int el=inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[i]!=el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el=inArray[i];
            count=1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}

