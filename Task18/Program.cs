// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти [1-4]: ");
string quater = Console.ReadLine();

string GetCoordinate(string quarterNum)
{
    if (quarterNum == "1") return "x > 0, y > 0";
    if (quarterNum == "2") return "x < 0, y > 0";
    if (quarterNum == "3") return "x < 0, y < 0";
    if (quarterNum == "4") return "x > 0, y < 0";
    return "Введите число от 1 до 4";
}

string result = GetCoordinate(quater);
Console.WriteLine(result);
