// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите колличество строк");
// int rows = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов");
// int columns = Convert.ToInt32 (Console.ReadLine());

// double [,] matrix = new double[rows ,columns];
// Random random = new Random();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//          matrix[i,j] = Math.Round((random.NextDouble()*20-10),1);

//        Console.Write("{0, 10}", matrix[i,j].ToString("0.0"));

//     }
//     Console.WriteLine();
// }

//______________________________________________________________
// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Console.WriteLine("Введите координаты");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[3, 4];
// FillArrayRandomNumbers(matrix);

// if (a > matrix.GetLength(0) || b > matrix.GetLength(1))
//     Console.WriteLine("Такого числа нет");

// else
// {
//     Console.WriteLine($"значение элемента {a} строки т {b} столбца равно {matrix[a - 1, b - 1]}");
// }
// PrintArray(matrix);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }

// }


//________________________________________________
//   Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.     

// Console.WriteLine("Введите колличество строк");
// int rows = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов");
// int columns = Convert.ToInt32 (Console.ReadLine());

// int [,] matrix = new int[rows ,columns];
// FillArrayRandomNumbers(matrix);

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double result = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         result = (result + matrix[i,j]);
//     }
//     result = result/rows;
//     Console.WriteLine(result + ";");
// }
// Console.WriteLine();

// PrintArray(matrix);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }

// }
