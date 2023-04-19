// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int powNumbers = PowN(numberA, numberB);
Console.WriteLine($"{numberA}, {numberB} -> {powNumbers}");

int PowN(int numA, int numB)
{
    int powN = 0;
    int temp = numA;
    for (int i = 1; i <= numB - 1; i++)
    {
        checked // Проверка на переполнение
        {

            powN = temp * numA;
            temp = powN;
        }
    }
    return powN;
}