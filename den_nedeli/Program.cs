/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. */

int userEnter;
int.TryParse(Console.Readline()!, out userEnter);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(userEnter <= 7)
{
    if (userEnter == a)
{
        Console.WriteLine("Понедельник");
}

    if (userEnter == b)
{
        Console.WriteLine("Вторник");
}

    if (userEnter == с)
{
        Console.WriteLine("Среда");
}

    if (userEnter == d)
{
        Console.WriteLine("Четверг");
}

    if (userEnter == e)
{
        Console.WriteLine("Пятница");
}

    if (userEnter == f)
{
        Console.WriteLine("Этот День Выходной - Суббота");
}

    if (userEnter == g)
{
        Console.WriteLine("Этот День Выходной - Воскресенье");
}
}
else
{
    Console.WriteLine("Введите правильное число");
    break;
}