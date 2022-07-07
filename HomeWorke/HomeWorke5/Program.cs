

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(100, 1000);

    return array;    
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


int CountElement(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    
    return count;
}

int[] CreateNRandomArray(int sizeN)
{
    int[] array = new int[sizeN];

    for(int i = 0; i < sizeN; i++)
         array[i] = new Random().Next(0, 10);

    return array;    
}   

void ShowNArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int ElementSum(int[] array)
{
    int sumOfElement = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sumOfElement += array[i]; 
    }
    return sumOfElement;
}

double[] CreateNewRandomArray(int lenght)
{
    double[] array = new double[lenght];

    for(int i = 0; i < lenght; i++)
         array[i] = (new Random().Next(0, 100)) + Math.Round(new Random().NextDouble(), 2) ;

    return array;    
}   

void ShowNewArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)  max = array[i];
    }
    return max;

}

double MinNumber(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)  min = array[i];
    }
    return min;

}

//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите желаемое колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateRandomArray(size);
ShowArray(myarray);
Console.WriteLine("Колличество четных чисел в массиве = " + CountElement(myarray));
Console.WriteLine();

//Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите желаемое колличество элементов массива: ");
int sizeN = Convert.ToInt32(Console.ReadLine());

int[] myNarray = CreateNRandomArray(sizeN);
ShowNArray(myNarray);
Console.WriteLine("Сумма элементов стоящих на нечетных позициях = " + ElementSum(myNarray)); 
Console.WriteLine();

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите желаемое колличество элементов массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

double[] mynewarray = CreateNewRandomArray(lenght);
ShowNewArray(mynewarray);
Console.WriteLine(" Max = " + MaxNumber(mynewarray));
Console.WriteLine(" Min = " + MinNumber(mynewarray));
Console.WriteLine("Разниица = " + Math.Round((MaxNumber(mynewarray) - MinNumber(mynewarray)), 2));