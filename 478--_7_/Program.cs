// из трехзначного числа показывает вторую цифру

int rand = new Random().Next(100, 1000);

Console.WriteLine(rand);

int a = rand / 10;
int b = a % 10;

Console.WriteLine(b);