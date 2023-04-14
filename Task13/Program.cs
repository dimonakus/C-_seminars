// // Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message);
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result =Convert.ToInt32(value);
    return result;
}

int GetThirdRank (int number)
{
    while (number > 999)
    {
        number /=10;
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число >");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}







// int number = new Random().Next();
// Console.WriteLine($"Случайное число -> {number}");

// int ThirdDigit(int num) // num = number
// {
//     int i = 0;
// while (num<1000)
// //int first = num / 100;
// //int third = num % 10;
// //int answer = first * 10 + third;
// return result;

//     // int i = 0;
//     // while (number<1000)
//     // {
//     //     int result = num /10;
//     //     i++;
//     // }

// }
// Console.WriteLine($"Тестирование результа -> {ThirdDigit(number)}");


// //


// // int DeleteCenterDigit(int num) // num = number
// // {
// //     int first = num / 100;
// //     int third = num % 10;
// //     int answer = first * 10 + third;
// //     return answer;
// // }
// // Console.WriteLine($"Двузначное число -> {DeleteCenterDigit(number)}");





























// int count = 0;
// // do
// // {
// //     int result = number / 10;
// //     count++;
    
// //     Console.WriteLine(result);
// // } 

// while (number < 1000)
// {
// int result = number / 10;
// count++;
// Console.WriteLine(result);
// }






// // i = 0;
// //                     while (i < 100)
// //                     {
// //                         i = i + 5;
// //                         s = s + i;
// //                     }
// //                     break; 


// //int count = 0;
// //int result = 0;

// //Синтаксис функции while

// // int n = 0;
// // while (n < 5)
// // {
// //     Console.Write(n);
// //     n++;
// // }
// // // Output:
// // // 01234