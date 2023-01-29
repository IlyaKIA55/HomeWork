// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine($"максимальное число {numberA}");
    }
    else
    {
        Console.WriteLine($"максимальное число {numberC}");
    }
}
else
{
    if (numberB>numberC)
    {
        Console.WriteLine($"максимальное число {numberB}");
    }
    else
    {
        Console.WriteLine($"максимальное число {numberC}");
    }
}