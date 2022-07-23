
int SumOfDigits(int n)
{
    if(n / 10 != 0) 
    {
        return  1 + SumOfDigits(n / 10);
    }
    else return 1;
}


int Sum(int n, int m)
{
    if(m > n) 
    {
        return m + Sum(n, m - 1);
    }
    else return n;
        
}

// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

Console.Write("Введите число кол-во цифр которого необходимо узнать : ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(num));

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите первое число: ");
int minnum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int maxnum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sum(minnum,maxnum));