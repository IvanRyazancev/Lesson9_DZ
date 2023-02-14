// Задача №2. Показать натуральные числа от M до N, N и M заданы.

void PrintNums(int X, int Y, int K)
{    
    if (X == Y) Console.WriteLine($"N: 1");
    else if (X < Y && X <= K && K <= Y)
    {         
        Console.WriteLine($"M = : {K}");
        PrintNums(X, Y, K + 1);        
    }
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int A = M;
PrintNums(M, N, A);