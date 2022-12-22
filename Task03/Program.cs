// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите количество строк первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное возможное значение матрицы");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное возможное значение матрицы");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальное возможное значение матрицы");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное возможное значение матрицы");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstarray = FillArray(rows1, columns1, min1, max1);
int[,] secondarray = FillArray(rows2, columns2, min2, max2);

Console.WriteLine("Первая матрица:");
PrintArray(firstarray);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(secondarray);
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

int[,] MultiplicationArr(int[,] firstArr, int[,] secondArr)
{
    int[,] resultArr = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    for (int i = 0; i < firstArr.GetLength(0); i++)
    {
        for (int j = 0; j < secondArr.GetLength(1); j++)
        {
            for (int k = 0; k < secondArr.GetLength(0); k++)
            {
                resultArr[i, j] += firstArr[i, k] * secondArr[k, j];
            }
        }
    }
    return resultArr;
}
Console.WriteLine();
Console.WriteLine("Результирущая матрица:");
PrintArray(MultiplicationArr(firstarray, secondarray));