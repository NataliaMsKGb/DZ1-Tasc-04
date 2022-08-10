// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое целое число");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число, не равное первому");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число, не равное первому и второму");
int c=Convert.ToInt32(Console.ReadLine());

if(a>b)
if(a>c)
{
    Console.WriteLine($"Максимальное число: {a}");
}
if (b>a)
if (b>c)
{
    Console.WriteLine($"Максимальное число: {b}");
}
if (c>a)
if (c>b)
{
    Console.WriteLine($"Максимальное число: {c}");
}


