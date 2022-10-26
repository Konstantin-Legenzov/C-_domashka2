// выводит 3ю цифру если нет то пишет нет

int N;
N = new Random().Next(0, 10000);

Console.WriteLine(N);

int i = 100;
int i2 = 1000;
int i3 = 10000;

int result;
int result2;
int result3;

if (N < i)
{
    Console.WriteLine("Нет 3го числа");
}
if (N < i2 && N > i)
{
    result = N % 10;
    Console.WriteLine(result);
}
if (N < i3 && N > i2)
{
    result2 = N % 100;
    result3 = result2 / 10;
    Console.WriteLine(result3);
}