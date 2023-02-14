// Задача №3. Найти сумму элементов от M до N, N и M заданыvoid PrintNums(int X, int Y, int K).

int PrintNums(int X, int Y, int K)
{    
    if (X == Y) Console.WriteLine($"N: 1");
    else if (X < Y && X <= K && K <= Y)
    {         
        Console.WriteLine($"M = : {K}");
        PrintNums(X, Y, K + 1);        
    }
    return K;      
}

void SumNums(int X, int Y, int K, int Sum)
{
    if (X == Y) Console.WriteLine($"N: 1");
    else if (X < Y && X <= K && K <= Y)
    {                 
        SumNums(X, Y, K + 1, Sum = Sum + K);        
    }  
    if (K == Y)
    {
        Console.WriteLine($"Сумма чисел от M до N = : {Sum}");
    }            
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int A = M;
int summary = 0;
PrintNums(M, N, A);
SumNums(M, N, A, summary);