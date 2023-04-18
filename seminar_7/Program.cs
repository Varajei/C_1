// // Start();

// // void Start()
// // {
// //     int rows = SetNumber("rows");
// //     int columns = SetNumber("columns");

// //     int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
// //     PrintMatrix(matrix);
// // }

// // int SetNumber(string numberName)
// // {
// //     Console.Write($"Enter number {numberName}: ");
// //     int num = Convert.ToInt32(Console.ReadLine());
// //     return num;
// // }

// // int[,] GetRandomMatrix(int rows, int columns, int min, int max)
// // {
// //     int[,] array = new int[rows, columns];

// //     var rand = new Random();

// //     for (int i = 0; i < rows; i++)
// //     {
// //         for (int j = 0; j < columns; j++)
// //         {
// //             array[i, j] = rand.Next(min, max + 1);
// //         }
// //     }

// //     return array;
// // }

// // void PrintMatrix(int[,] matrix)
// // {
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             System.Console.Write($"{matrix[i, j]} ");
// //         }
// //         System.Console.WriteLine();
// //     }

// // }

// /* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 */

// Start();
// void Start()
// {
//     int rows = SetNumber("m");
//     int columns = SetNumber("n");
//     int[,] matrix = GetMatrix(rows, columns);
//     PrintMatrix(matrix);
// }

// int SetNumber(string text = "")
// {
//     Console.Write($"Enter number {text}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetMatrix(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = i + j;
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
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Второй вариант решения

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i+j;
//         }
//     }
// }
// Console.Clear();
// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.



// start();

// void start()
// {
//     Console.Clear();
//     int rows = Enter("m = ");
//     int columns = Enter("n = ");
//     Console.WriteLine();
//     int[,] matrix =  GenerateArray(rows,columns );
//     printMatrix(matrix);
//     Console.WriteLine();
//     GenerateNew(matrix);
//     printMatrix(matrix);
// }
// int Enter(string numb)
// {
//     Console.Write(numb);
//     string num = Console.ReadLine();
//     int result =int.Parse(num);
//     return result;
// }
// int[,] GenerateArray(int rows, int columns)
// {
//     int[,] matrix = new int[rows, columns];
    
//     for (int i = 0; i < rows; i++)
//     {
//        for (int j = 0; j < columns; j++)
//        {
//             matrix[i,j] = i + j;
//        }
//     }
//     return matrix;
// }
// void printMatrix(int[,] matrix)
// {
//       for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// int[,] GenerateNew(int[,] matrix)
// {
    
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if ((i%2==0) && (j%2==0))
//            {
//             matrix[i,j]=Convert.ToInt32(Math.Pow(matrix[i,j],2));
//            }
//        }
//     }
//     return matrix;
// }


//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Start();
void Start()
{
    Console.Clear();
    int rows = SetNumber("m");
    int columns = SetNumber("n");
    Console.WriteLine();
    int[,] matrix = GetRandomMatrix(rows, columns, 2, 9);
    PrintMatrix(matrix);
    Console.WriteLine($"Сумма элементов главной диагонали = {GetSum(matrix)}");
    Console.WriteLine();
    GetPower(matrix);
    PrintMatrix(matrix);
    Console.WriteLine($"Сумма элементов главной диагонали 2 = {GetSum(matrix)}");
    Console.WriteLine();
}

int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max+1);
        }
    }
    return array;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] GetPower(int [,] array)
{
    
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i%2 == 0 && j%2 == 0)
            array[i, j] = array[i,j] * array[i,j];
        }
    }
    return array;
}

int GetSum(int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i == j)
            sum+= array[i,j];
        }
    }
    return sum;
}