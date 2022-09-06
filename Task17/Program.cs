// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)  // в else нет смысла, т.к. есть return по которому выйдем из if
{
    if (xc > 0 && yc > 0) return "1-я четверть";
    if (xc < 0 && yc > 0) return "2-я четверть";
    if (xc < 0 && yc < 0) return "3-я четверть";
    if (xc > 0 && yc < 0) return "4-я четверть";
    return "Введены некорректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);
