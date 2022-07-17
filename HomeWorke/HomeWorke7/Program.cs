
double[,] CreateRandom2dArray(int line,int columns, int minValue, int maxValue)
{
   double[,] myarray = new double[line, columns];

    for(int i = 0; i < line; i++)
        for(int j = 0; j < columns; j++)
         myarray[i,j] = (new Random().Next(minValue, maxValue + 1)) + Math.Round(new Random().NextDouble(), 1);

    return myarray;    
}   

void Show2dArray(double[,] myarray)
{
    for(int i = 0; i < myarray.GetLength(0); i++)
    {
        for(int j = 0; j < myarray.GetLength(1); j++)
            Console.Write(myarray[i,j] + " ");
        
        Console.WriteLine();
    }        
}

double ShowElement( double[,] array, int linePosition, int columnsPosition)
{
    
    if(linePosition  > array.GetLength(0)  || columnsPosition > array.GetLength(1))
    {
        Console.Write("No element");
        Environment.Exit(0);
    }
    return array[linePosition - 1, columnsPosition - 1];
}

int[,] CreateRandomArray(int lineN,int columnsN, int minValueN, int maxValueN)
{
   int[,] myarray = new int[lineN, columnsN];

    for(int i = 0; i < lineN; i++)
        for(int j = 0; j < columnsN; j++)
         myarray[i,j] = (new Random().Next(minValueN, maxValueN + 1));

    return myarray;    
}   

void ShowArray(int[,] myarray)

{
    for(int i = 0; i < myarray.GetLength(0); i++)
    {
        for(int j = 0; j < myarray.GetLength(1); j++)
            Console.Write(myarray[i,j] + "  ");
        
        Console.WriteLine();
    }        
}

void Average(int[,] myarray)
{
    for(int i = 0; i < myarray.GetLength(1); i++)
    {
        double sum = 0;
        double averageColumnSum = 0;
        for(int j = 0; j < myarray.GetLength(0); j++)
        {
            sum += myarray[j, i];
        }
        Console.Write((Math.Round((averageColumnSum = (sum / myarray.GetLength(0))),1)) + "; ");
            
    }    
}


// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите колличество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(line, columns, minValue, maxValue);

Show2dArray(array);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Введите номер строки: ");
int linePosition = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int columnsPosition = Convert.ToInt32(Console.ReadLine());

double element = ShowElement(array, linePosition, columnsPosition);
Console.WriteLine(element);


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите колличество строк массива: ");
int lineN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columnsN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число в массиве: ");
int minValueN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число в массиве: ");
int maxValueN = Convert.ToInt32(Console.ReadLine());

int[,] arrayN = CreateRandomArray(lineN, columnsN, minValueN, maxValueN);
ShowArray(arrayN);
Console.Write("Среднее арифметическое по столбцам: ");
Average(arrayN);