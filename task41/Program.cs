// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");
int[] arrey = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // вывод массива сразу всеми вводимыми числами

int NumbersInArrey(int[] arrey)
{
    int num = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] > 0) num++;
    }
    return num;
}
int num = NumbersInArrey(arrey);
Console.WriteLine($"Пользователем введено {num} числа/чисел больше нуля");