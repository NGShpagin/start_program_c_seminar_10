// Задача 2. Домашнее задание
// Повторение матриц. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            Console.Write($"i({i}),j(0-3),k({k}): ");
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("  ");
    }
}

bool CheckArray(int[,,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i,j,k] == number) return true;
                else continue;
            }
        }
    }
    return false;
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int num = new Random().Next(10, 100);
                while (CheckArray(matr, num) == true)
                {
                    num = new Random().Next(10, 100);  
                }
                matr[i, j, k] = num;
            }
        }
    }
}

int[,,] matrix = new int[3, 4, 3];
FillArray(matrix);
PrintArray(matrix);