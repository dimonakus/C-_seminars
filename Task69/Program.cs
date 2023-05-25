//Задача 69: Напишите программу, которая на вход принимает два числа А и B,
// и возводит число А в целую степень B с помощью рекурсии.
//А = 3; B = 5 -> 243 (3^5)
//A = 2; B = 3 -> 8


Console.WriteLine("Введите первое целое число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int degree = Degree(numberA, numberB);
Console.WriteLine(degree);

int Degree(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA*Degree(numA, numB-1);
}