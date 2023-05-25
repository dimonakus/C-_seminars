// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

//Поскольку функцией Аккермана быстро переполняется стек, данным условием попытался ограничить переполнение стека при выполнении программы
if (m < 0 || n < 0)
{
    Console.WriteLine("По условию этой задачи, числа m и n должны быть положительными для демонстрации функции");
}
else if ((m == 1 && n > 19200)
    || (m == 2 && n > 9600)
    || (m == 3 && n > 11)
    || (m == 4 && n > 0)
    || m > 4)
{
    Console.WriteLine("К сожалению, существует предел возможности компьютера, на большие числа я не способен рассчитать в рамках этой программы");
}
else if (m == 0)
{
    Console.Write("Функция Аккермана A(m,n) = ");
}
else Console.Write("Функция Аккермана A(m,n) = ");

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)
{
    if (m < 0 || n < 0) return;
    else if ((m == 1 && n > 19200)
        || (m == 2 && n > 9600)
        || (m == 3 && n > 11)
        || (m == 4 && n > 0)
        || m > 4) return;

    Console.Write(Akkerman(m, n));
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}