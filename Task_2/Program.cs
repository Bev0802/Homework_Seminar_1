/* Задача 2: 
Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3 */

Console.WriteLine("Введите первое целое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вы ввели {a} и {b}. Теперь сравним числа.");

int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    Console.WriteLine($"max = {max}");
}
else
{
    max = b;
    Console.WriteLine($"max = {max}");
}

if (a < b)
{   min = a;
    Console.WriteLine($"min = {min}"); }
else
{
    max = b;
    Console.WriteLine($"min = {min}");
}