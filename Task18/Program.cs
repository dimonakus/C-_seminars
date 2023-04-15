// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string result = Coordinate(numberQuarter);

Console.WriteLine(result == "ошибка" ? "Неправильный номер четверти": result);

//string res = result >0 && result <0
// string result = quarter > 0
//             ?$"Указанные координаты соответсвуют четверти -> {quarter}"
//             :"Введены некорректные координаты";

string Coordinate (int num)
{
    if(num == 1) return "x > 0, y > 0";
    if(num == 2) return "x < 0, y > 0";
    if(num == 3) return "x < 0, y < 0";
    if(num == 4) return "x > 0, y < 0";
    return "ошибка";
}