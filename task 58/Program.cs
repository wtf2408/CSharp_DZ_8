// Задача 58: Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matrix1 = {
    {2,4},
    {3,2}
};
int[,] matrix2 = {
    {3,4},
    {3,3}
};
int[,] ProductOfMatrix(int[,] matr1, int[,] matr2)
{
    int[,] resMatrix = new int[2,2];
    resMatrix[0,0] = (matr1[0,0] * matr2[0,0]) + (matr1[0,1] * matr2[1,0]);
    resMatrix[0,1] = (matr1[0,0] * matr2[0,1]) + (matr1[0,1] * matr2[1,1]);
    resMatrix[1,0] = (matr1[1,0] * matr2[0,0]) + (matr1[1,0] * matr2[1,0]);
    resMatrix[1,1] = (matr1[1,0] * matr2[0,1]) + (matr1[1,1] * matr2[1,1]);
    return resMatrix;
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
PrintArray2d(ProductOfMatrix(matrix1, matrix2));