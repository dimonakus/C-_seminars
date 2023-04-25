// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите длину стороны А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool Istriangle(int numa, int numb, int numc)
{
    //if (numa + numb > numc && numb + numc > numa && numa + numc > numb)
    return numa + numb > numc && numb + numc > numa && numa + numc > numb;
    //return true;
    // else return false;
}

bool triangle = Istriangle(numberA, numberB, numberC);

Console.WriteLine(triangle ? "Такой треугольник существует" : "Такого треугольника нет");
