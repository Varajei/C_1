// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// коментарий ставиться с помощью команды Ctrl+/


Console.WriteLine("Enter nuber :");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

int sqr = num * num;

Console.WriteLine($"sqr = {sqr}"); // $ - форматирование строк

// double sqr = Math.Pow(num, 2);  - метод возведения числа в степень где num переменная а 2 степень
