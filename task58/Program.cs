// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Console.Write("Введите число строк m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов n = ");
// int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
int n = 2; 
int m = 2; 
int[,] matrix = new int[n, m];
Console.WriteLine("Первая матрица");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 9);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int n1 = 2; 
int m1 = 2; 
Console.WriteLine("Вторая матрица");
int[,] matrix2 = new int[n1, m1];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = new Random().Next(0, 9);
        Console.Write(matrix2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Произведение матриц");
int[,] res = new int[n, m1];
for (int i = 0; i < res.GetLength(0); i++)
{
    for (int j = 0; j < res.GetLength(1); j++)
    {
        int sum = 0;
        for(int k = 0; k < res.GetLength(1); k++)
        {
            sum = sum + matrix [i,k] * matrix2[k,j];
        }
        res[i, j] = sum;
        Console.Write(res[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();