// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Result, S = {Numbers(M, N)}");
Console.ReadLine();

 int Numbers(int M, int N)
{
    if (M == 0) 
    return (N * (N + 1)) / 2;            
    else if (N == 0) 
    return (M * (M + 1)) / 2;     
    else if (M == N) 
    return M;                      
    else if (M < N) 
    return N + Numbers(M, N - 1); 
    else 
    return N + Numbers(M, N + 1); 
}