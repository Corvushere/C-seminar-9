/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


/*
int Input (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

int Numb (int num)
{
    if (num == 1)
    {
        return 1;
    }
    else 
    {
        Console.Write ($"{num}, ");
        num = Numb (num-1);
    }
    return num;
}

int n = Input ("Введтите число N: ");
Console.WriteLine (Numb (n));
*/



/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


/*
int Input (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}


int Sum (int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else 
    {
        n += Sum (m, n-1);
    }
    return n;
}

int m = Input ("Введите число M: ");
int n = Input ("Введите число N: ");
Console.Write ($"Сумма чисел от {m} до {n} = {Sum (m, n)}");
*/


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/



int Input (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}


int funAkk (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (m > 0 && n == 0)
    {
        n = funAkk (m - 1, 1);
        return n;
    }
    else if (m > 0 && n > 0)
    {
        n = funAkk (m, n - 1);
        n = funAkk (m - 1, n);
    }
    return n;
}

int m = Input ("Введите число M: ");
int n = Input ("Введите число N: ");
Console.WriteLine ($"A ({m}, {n}) = {funAkk (m, n)}");

Console.WriteLine ();
