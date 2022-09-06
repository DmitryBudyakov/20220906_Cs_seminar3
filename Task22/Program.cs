// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    int count = 1;
    while (count <= num)
    {
        int square = count * count;
        Console.WriteLine($"{count} -> {square,3}");    // 3 - кол-во символов выводим во вторых скобках
        count++;
    }
}

Square(number);