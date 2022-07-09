// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
double[] CreateArray(double size)
{
    double[] array = new double[size];

    for(double i = 0; i < size; i++)
    {
         Console.Write("Введите число : ");
         double number = Convert.ToInt32(Console.ReadLine());
         array[i] = number;
    }
    return array;    
}   

void ShowArray(double[] array)
{
    for(double i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double CountPositiveNum(double[] array)
{
    double count = 0;
    for(double i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;     
    }
    return count;
}

Console.Write("Введите кол-во элементов : ");
double size = Convert.ToInt32(Console.ReadLine());

double[] myarray = CreateArray(size);
ShowArray(myarray);

Console.WriteLine(CountPositiveNum(myarray));*/


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double DotX(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2); 

    return X;
}

Console.Write("Введите значение b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());

double Xx = DotX(b1, k1, b2, k2);


Console.Write(Xx + ";" + (k1 * Xx + b1) );