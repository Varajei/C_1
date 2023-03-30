// Console.Write("Enter number X :");
// int numX = int.Parse(Console.ReadLine());

// Console.Write("Enter number Y :");
// int numY = int.Parse(Console.ReadLine());

// if (numX > 0 && numY > 0)
// {
//     Console.WriteLine("Sector 1");
// }
// else if (numX < 0 && numY > 0)
// {
//     Console.WriteLine("Sector 2");
// }
// else if (numX < 0 && numY < 0)
// {
//     Console.WriteLine("Sector 3");
// }
// else if (numX > 0 && numY < 0)
// {
//     Console.WriteLine("Sector 4");
// }

// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Enter Sector :");
// int num = int.Parse(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("X>0; Y>0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("X>0; Y<0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("X<0; Y<0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("X<0; Y>0");
// }
// else
// {
//     Console.WriteLine("Нет такого)");
// }

// Console.Write("Enter sector ");
// int num = int.Parse(Console.ReadLine());

// switch (num)
// {
//     case 1: Console.WriteLine("X > 0 and Y > 0"); break;
//     case 2: Console.WriteLine("X < 0 and Y > 0"); break;
//     case 3: Console.WriteLine("X < 0 and Y < 0"); break;
//     case 4: Console.WriteLine("X > 0 and Y < 0"); break;
//     default: Console.WriteLine("Error"); break;
// }

// // На вход будет подаваться число (сумма вклада). При значении меньше 100, будет начислено 5 %,
// если значение находится в диапазоне от ста до двухсот — 7 %, если больше — 10 %.
// Отработав, программа должна вывести общую сумму с начисленными процентами.
// Для решения этой задачи воспользуемся выражением Convert.ToDouble(Console.ReadLine()), которое нам пригодится для получения вводимого с клавиатуры числа.

// --- Пусть банк регулярно начисляет по всем вкладам не только положенные по договору проценты, но еще и бонусы.
// --- И пусть, к примеру,  банк решит выполнить доначисление по всем клиентским вкладам в размере 15 единиц без учета суммы.
// --- Поменяем программу, отображенную выше, чтобы к итоговой сумме были добавлены еще и бонусы.

// Console.Write("Enter summa ");
// double num = Convert.ToDouble(Console.ReadLine());

// if (num < 100)
// {
//     num = num * 0.05 + num;
// }
// else if (num >= 100 && num < 200)
// {
//     num = num * 0.07 + num;
// }
// else if (num >= 200)
// {
//     num = num * 0.1 + num;
// }

// Console.WriteLine($"На выходе получит сумму равную = {num}");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Enter X1");
// double X1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter Y1");
// double Y1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter X2");
// double X2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter Y2");
// double Y2 = double.Parse(Console.ReadLine());

// double AB = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1));

// Console.WriteLine(AB);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Clear ();
// Console.Write("Введите число N: ");
// string strNumN = Console.ReadLine();
// int numN = Convert.ToInt32(strNumN);
// int count = 1;


// Console.WriteLine($"Квадраты чисел от 1 до {numN}:");
// while (count <= numN)
// {
//     // Console.Write($"{count*count}  ");
//     Console.Write($" {Math.Pow((count), 2)} ");
    
// count++;
// }
// Console.WriteLine();

// Вариант решения 2

// Console.WriteLine("Vvedite chislo 1");
// int input1 =int.Parse(Console.ReadLine());
// for (int i = 1; i <= input1; i++)
// {   
//     Console.Write ($" {i*i}");
// }

