// Задача 62.Напишите метод, который заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
string[,] array = {
    {"0","0","0","0"},
    {"","","","0"},
    {"","","","0"},
    {"","0","0","0"},
};
string[,] SpiralFillingArray(string[,] arr)
{
    int count = 1;
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        arr[0, j] += count;
        count++;
    }
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        arr[i, 3] += count;
        count++;
    }
    for (int j = arr.GetLength(1)-1; j > 0; j--)
    {
        arr[3, j] += count;
        count++;
    }
    for (int i = arr.GetLength(1) - 1; i > 1; i--)
    {
        arr[i, 0] += count;
        count++;
    }
    for (int j = 0; j < arr.GetLength(1) - 2; j++)
    {
        arr[1, j] += count;
        count++;
    }
    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        arr[i, 2] += count;
        count++;
    }
    for (int j = arr.GetLength(1) - 3; j > 0; j--)
    {
        arr[2, j] += count;
        count++;
    }


    return arr;
}
void PrintArray2d(string[,] arr)
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
PrintArray2d(SpiralFillingArray(array));
