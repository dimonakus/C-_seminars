// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int coefficient = 0;
int constant = 1;
int x_coord = 0;
int y_coord = 1;
int line1 = 1;
int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y = {lineData1[coefficient]} * x + {lineData1[constant]} и y = {lineData2[coefficient]} * x + {lineData2[constant]} ");
    Console.WriteLine($"имеет координаты {coord[x_coord]}, {coord[y_coord]}");
}

//Ввод числа
double Prompt(string message)
{
    Console.Write(message); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    double result = Convert.ToDouble(value); //преобразует строку в целое число
    return result; //возвращает результат
}

//Ввод данных по прямой
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coefficient] = Prompt($"Введите коэффициент для {numberOfLine}-ой прямой > ");
    lineData[constant] = Prompt($"Введите константу для {numberOfLine}-ой прямой > ");
    return lineData;
}

//Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    // coord[x_coord] = (lineData1[constant] - lineData2[constant]) / 
    // (lineData2[coefficient] - lineData1[coefficient]);
    coord[x_coord] = Math.Round((lineData2[constant] - lineData1[constant]) / 
    (lineData1[coefficient] - lineData2[coefficient]), 1);
    coord[y_coord] = Math.Round(lineData1[coefficient] * coord[x_coord] + 
    lineData1[constant], 1);
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}