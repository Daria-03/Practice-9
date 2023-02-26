// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine());

int Akermann (int M, int N)
{
    if (M == 0) 
    return N + 1;
    if (M != 0 && N == 0) 
    return Akermann(M - 1, 1);
    if (M > 0 && N > 0) 
    return Akermann(M - 1, Akermann(M, N - 1));
return Akermann(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел A ({M},{N}) = {Akermann(M, N)}");