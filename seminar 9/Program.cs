// string[,] WrighteArray()
// {
//     string[,] result = {{"А и Б сидели на трубе что с ними стало ?", "Упали", "Пропали", "Украли", "Уснули", "Упали"},
// {"Какое смегодня занятие по счету", "3", "5", "7", "9", "9"},
// {"Дважды два = ?", "3", "6", "4", "7", "4"},
// {"У кого не пашет микрофон?", "Сергей", "Алексей", "Володя", "Габиль", "Алексей"},
// {"Сколько нас в комнате?", "10", "7", "12", "20", "10"},
// {"Какое сегодня число","20","24","12","4","20"},
// {"Какая сейчас погода в Костроме","+10","+5","+1","+20","+10"},
// {"Кто смотрит вопросы в инете?", "Сергей", "Алексей", "Володя", "Габиль", "Алексей"},
// {"Средняя ЗП Джуна","50","60","70","80","50"},
// {"Средняя ЗП Мидла","100","120","140","180","140"},
// {"Средняя ЗП Синьера","180","200","220","240","240"},};
//     return result;
// }

// string[,] questions = WrighteArray();
// int count = 0;
// for (int i = 0; i < questions.GetLength(0); i++)
// {
//     Console.WriteLine(questions[i, 0]);
//     for (int j = 1; j < questions.GetLength(1) - 1; j++)
//     {
//         Console.WriteLine(questions[i, j]);
//     }
//     string otvet = Console.ReadLine();
//     if (otvet == questions[i, questions.GetLength(1)-1])
//     {
//         count += 1;
//     }

// }

// Console.WriteLine($"Правильных ответов {count} ");

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

int SumNumbers(int number)
{
    // if (number == 0) return 0;
    // return (number % 10 + SumNumbers(number / 10));
    return (number == 0) ? 0 : (number % 10 + SumNumbers(number / 10));
}
Console.WriteLine($"Сумма числа {num} равна {SumNumbers(num)}");