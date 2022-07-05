// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int NumberSum(int num)
{
    int sum = 0;

    while(num > 0){
        int i = num % 10;
        num = num / 10;
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers = NumberSum(num);
Console.WriteLine("Сумма чисел = " + SumOfNumbers);


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] NewArray(){

    int num = new Random().Next(0, 9);
    int[] Array = new int[num];
    
    for(int i = 0; i < Array.Length; i++){
        Array[i] = new Random().Next(0, 100);
        Console.Write( Array[i] + " ");
    }
    return Array;
}

    int[] arr = NewArray();

void PrintArray(int[] arr)
{
    
 Console.WriteLine("[{0}]", string.Join(", ", arr));
}
PrintArray(arr);


    



