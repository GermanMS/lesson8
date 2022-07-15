// // Задача 56: Задайте прямоугольный двумерный массив. 
// // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Write("Введите число строк n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов m =  , Где m > n чтобы получился приятоугольный двумерный массив ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 9);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
int min = int.MaxValue;
int x = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
    }
    if(sum < min)
    {
        min = sum;
        x = i+1;
    }
}
Console.WriteLine($"\nСумма элементов в строке = {min}");
Console.Write ($"Номер строки - {x}");

