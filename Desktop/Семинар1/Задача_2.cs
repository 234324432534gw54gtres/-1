//  Задача № 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое второе ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b) Console.Write($"число{a} = {b}");
// else if (a > b) Console.Write($"max = {a}");
// else Console.Write($"max = {b}");

// Задача № 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// // 22 3 9 -> 22
// Console.Write("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (max < b) max = b;
// if (max < c) max = c;
// Console.WriteLine($"max = {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// // -3 -> нет
// // 7 -> нет
// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0) Console.WriteLine($"Число {a} является четным");
// else Console.WriteLine($"Число {a} не является четным");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Ввод всех четных чисел");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
while (a <= n);
{
    if (n%2 == 0)
    a++;
    Console.WriteLine(a++"");
    if (a>n)
    break;
}