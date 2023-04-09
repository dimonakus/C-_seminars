//Задача 2: Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number1==number2)
{
    Console.Write ("Вы оба раза ввели одно и то же число :(");    
}
else
{
if (number1>number2)
{
    max = number1;
    min = number2;
    Console.WriteLine ($"Число {number1} - Максимальное из двух введенных чисел");
    Console.WriteLine ($"Число {number2} - Минимальное из двух введенных чисел");
}
else
{
    max = number2;
    min = number1;
    Console.WriteLine ($"Число {number2} - Максимальное из двух введенных чисел");
    Console.WriteLine ($"Число {number1} - Минимальное из двух введенных чисел");

}
 }   