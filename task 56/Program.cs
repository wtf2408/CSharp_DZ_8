// Задача 56: Задайте двумерный массив. Напишите метод, который будет находить строку с наименьшей суммой элементов.

int[,] Create2dArray(int length0, int length1)
{
    int[,] arr = new int[length0, length1];
    Random random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 10);
        }
    }
    return arr;
}
void PrintArray2d(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinRow(int[,] arr)
{
    int sum = 0;
    int[] sumRows = new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        sumRows[i] = sum ;
        sum = 0;
    }
    int minSum = sumRows[0];
    for (int z = 0; z < sumRows.Length; z++)
    {
        if (sumRows[z] < minSum ) return z;
    }
    return 0;
}
int [,] array = Create2dArray(3,4);
PrintArray2d(array);
int i = MinRow(array);
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    Console.Write($"{array[i,j]} ");
}
Console.WriteLine("- строка с наименьшей суммой элементов.");
