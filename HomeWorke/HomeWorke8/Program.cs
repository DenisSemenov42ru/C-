//     Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRandomArray(int line,int columns, int minValue, int maxValue)
{
   int[,] myarray = new int[line, columns];

    for(int i = 0; i < line; i++)
        for(int j = 0; j < columns; j++)
         myarray[i,j] = (new Random().Next(minValue, maxValue + 1));

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

int[,] SortingElements(int[,] myarray)
{
    for(int i = 0; i < myarray.GetLength(0); i++)
    {
        for(int j = 0; j < myarray.GetLength(1) - 1; j++)
        {
            if(myarray[i,j] > myarray[i,j + 1]) 
            {
                int temp = myarray[i,j];
                myarray[i,j] = myarray[i,j + 1];
                myarray[i,j + 1] = temp;
            } 

        }
    }
    return myarray;
}

Console.Write("Введите колличество строк массива: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число в массиве: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число в массиве: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomArray(line, columns, minValue, maxValue);

ShowArray(array);

Console.WriteLine("Отсортированный массив");

ShowArray(SortingElements(array));


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int MinSumLineElements(int[,] myarray)
{
    int lineNumber = 0;
    int minSum = 0;
    for(int i = 0; i < myarray.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < myarray.GetLength(0); j++)
        {
            sum += myarray[i,j];
            lineNumber = i;
        }
        if(sum < minSum)
        {
            minSum = sum;
        }
    }
    return lineNumber;
}

Console.WriteLine("Задайте прямоугольный массив ");

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

Console.WriteLine("Строка с наименьшей суммой элементов: " + MinSumLineElements(arrayN));


//  Заполните спирально массив 4 на 4.

int[,] SpiralMatrix(int lineNew, int columnsNew)
{
    int[,] spiralarray = new int[lineNew, columnsNew];
    int i = 0;
    int j = 0;
    int firstNumber = 1;

    while (firstNumber <= lineNew * columnsNew)
{
        spiralarray[i, j] = firstNumber;
        if (i <= j + 1 && i + j < columnsNew - 1)
            ++j;
        else if (i < j && i + j >= lineNew - 1)
            ++i;
        else if (i >= j && i + j > columnsNew - 1)
            --j;
        else
            --i;
        ++firstNumber;
}
    return spiralarray; 

}

Console.Write("Введите колличество строк массива: ");
int lineNew = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columnsNew = Convert.ToInt32(Console.ReadLine());

ShowArray(SpiralMatrix(lineNew, columnsNew));