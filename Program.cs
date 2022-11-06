/*Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

Console.WriteLine($"Введи число М (длинна массива): ");
int m = int.Parse(Console.ReadLine() ?? "");
int[] arrayNumbers = new int[m];

void Numbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayNumbers[i] = int.Parse(Console.ReadLine() ?? "");
    }
}

int sum(int[] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0) count += 1;
    }
    return count;
}

Numbers(m);
void ArrayPrint(int[] arrayNumbers)
{
    for (int j = 0; j < arrayNumbers.Length; j++)
    {
        Console.Write($"{arrayNumbers[j]}, ");
    }
}

ArrayPrint(arrayNumbers);

Console.WriteLine($"-> {sum(arrayNumbers)} ");