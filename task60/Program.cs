// Задача 60:Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
int n = 3;
int m = 3;
int l = 3;

int[,,] matrix = new int[n, m, l];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            int x = new Random().Next(10, 100);
            bool chislo = Sravnenie(matrix, x);
            while (chislo == true)
            {
                x = new Random().Next(10, 100);
                chislo = Sravnenie(matrix, x);
            }
            matrix[i,j,k] = x;
            Console.Write($" Число - {x} Индексы [{i};{j};{k}]");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool Sravnenie(int[,,] array, int y)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (array[i, j, k] == y)
                {
                    return true;
                }

            }
        }
    }
    return false;
}