/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

//проверим на положительное число
if (N < 1)
{
    Console.WriteLine("Недопустимое число!");
}

int count = N;
if (count <= 1 && count <= N)
{
    if (count % 2 == 0)
        Console.Write($"{count} ");
    count++;
}




