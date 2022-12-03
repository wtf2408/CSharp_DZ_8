// Задача 54: Задайте двумерный массив. Напишите метод, который упорядочит по убыванию элементы каждой строки двумерного массива. И продемонстрируйте его работу.
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

int[,] SortingArrayElementsInDescendingOrder(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int z = 0; z < arr.GetLength(1); z++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int el = 0;
                if (arr[i, j] < arr[i, z])
                {
                    el = arr[i, z];
                    arr[i, z] = arr[i, j];
                    arr[i, j] = el;
                }
            }
        }
    }
    return arr;
}

int[,] array = Create2dArray(3,4);
PrintArray2d(array);
Console.WriteLine();
PrintArray2d(SortingArrayElementsInDescendingOrder(array));