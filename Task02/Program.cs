// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);
Console.WriteLine();

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j] + " ",3}");
        }
        Console.WriteLine();
    }
}

int FindMinSumRow(int[,] inputArray)
{
    int count = 0;
    int minsum = 0;
    int sum = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum = sum + inputArray[i, j];
        }
        if (i == 0)
            minsum = sum;
        else if (sum < minsum)
        {
            minsum = sum;
            count = i;
        }
    }
    Console.WriteLine($"Минимальная сумма = {minsum} на {count+1} строке");
    return minsum;
}
FindMinSumRow(array);