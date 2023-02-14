// Задача №1. Показать натуральные числа от N до 1, N задано.

void PrintNums(int n)
{    
    if (n == 1) Console.WriteLine($"N: 1");
    else
    {        
        Console.WriteLine($"N: {n}");
        PrintNums(n - 1);
    }
}

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
PrintNums(n);