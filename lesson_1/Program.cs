// double sqr = Math.Pow(num, 2);  - метод возведения числа в степень где num переменная а 2 степень

// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет



Console.WriteLine("Enter nuber :");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

Console.WriteLine("Enter nuber :");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);



if(num2*num2 == num){
    Console.WriteLine("Да");
    }
    else{Console.WriteLine("Нет");}

// Второй вариант

// Console.Clear();
// Console.Write("Введите A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (Math.Pow(numberB, 2) == numberA)
// {
//     Console.WriteLine("A является квадратом B");
// }
// else
// {
//     Console.WriteLine("A не является квадратом B");
// }