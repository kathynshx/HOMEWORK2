//homework ex 2
//a=5;b=7->max=7
//a=2;b=10->max=10
//a=-9;b=-3->max=-3
Console.WriteLine("Enter two numbers to compare");
Console.WriteLine("Введи первое число:");
int a = 
Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число:");
int b=
Convert.ToInt32(Console.ReadLine());

bool num1 = a > b;
bool num2 = a == b;
bool num3 = a < b;

if (num1)
{
    Console.WriteLine($"number {a} bigger than {b}");
}
else if (num2)
{
    Console.WriteLine($"Number {a} and {b} equal");
}
else if (num3)
{
    Console.WriteLine($"Number {a} smaller that {b}");
}

