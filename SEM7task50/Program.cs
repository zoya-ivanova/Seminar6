// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Укажите позицию элемента в строке: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите позицию элемента в столбце: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[4, 6]; //  массив 4 строки на 6 колонок
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> таких позиций в массиве нет");

void FillArray(int[,] array) // Заполнение массива рандомными числами от 1 до 6
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 6);
        }
    }
}

void PrintArray(int[,] array) //  Функция вывода массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

