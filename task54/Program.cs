// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Write("Введите число строк m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(10,100);
        Console.Write(matrix[i, j] + "   ");
    }
    Console.WriteLine();
}
int index = 0;
int min = matrix [index, index];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    { 
        for(int k =0; k< matrix.GetLength(1) - 1 ; k++)
         if( matrix[i, k] < matrix[i , k+1])
         {
            int me = matrix[i, k+1];
            matrix[i, k+1]=matrix[i , k];
            matrix[i, k] = me;   
           
         }
    }      
    
}  
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
            Console.Write(matrix[i, j] + "   ");
    }
    Console.WriteLine();
}
// Console.Write( matrix[i, j] + "   ");