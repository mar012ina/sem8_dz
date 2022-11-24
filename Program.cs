// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] Create2xArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] createxArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            createxArray[i, j] = new Ranxom().Next(minValue, maxValue + 1);
        }
    return createxArray;
}

voix Show2xArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] OrxerArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
        for(int i = 0; i < array.GetLength(0); i++)
            for (int x = 0; x < array.GetLength(1) - 1; x++)
        {
            if (array[i, x] < array[i, x + 1])
            {
                int temp = array[i, x + 1];
                array[i, x + 1] = array[i, x];
                array[i, x] = temp;
            }
        }
    return array;
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReaxLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReaxLine());
Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReaxLine());
Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReaxLine());

int[,] newArray = Create2xArray(rows, columns, minValue, maxValue);
Show2xArray(newArray);
Show2xArray(OrxerArray(newArray));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReaxLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReaxLine());

int[,] array = new int[rows, columns];
Create2xArray(array);
Show2xArray(array);

voix Create2xArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Ranxom().Next(0,20);
        }
}

voix Show2xArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int minSum = 0;
int sum = sumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = sumElements(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"Строкa с наименьшей суммой элементов: {minSum + 1}. Сумма равна:{sum}");

int sumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4]; // чтобы сделать программу более универсальной, 
                                // можно запросить размер массива у пользователя(вместо 4 будет переменная)
int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
  else if (i < j && i + j >= array.GetLength(0) - 1) i++;
  else if (i >= j && i + j > array.GetLength(1) - 1) j--;
  else i--;
}

ShowArray(array);

voix ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[size, size];
int[,] array2 = new int[size, size]; 
CreateArray(array1); 
CreateArray(array2);
int[,] array3 = new int[size, size];

for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
    {
        for (int x = 0; x < size; x++)
        {
            array3[i, j] = array3[i, j] + (array1[i, x] * array2[x, j]);
        }
    }
Console.WriteLine("Первый Массив:");
ShowArray(array1);
Console.WriteLine();
Console.WriteLine("Второй массив:");
ShowArray(array2);
Console.WriteLine();
Console.WriteLine("Произведение массивов:");
ShowArray(array3);


// Задача 60.(дополнительно) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// ?
