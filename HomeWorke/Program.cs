//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе  число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1 > num2)
{
    max = num1;
    Console.WriteLine("Ваше максимальное число равно : " + max);
}
else 
{
    max = num2;
    Console.WriteLine("Ваше максимальное число равно : " + max);
}




//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе  число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите  третье число: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

int maxnum;

if(numb1 > numb2)
{
    maxnum = numb1;
}

else
{
    maxnum = numb2;
}
 if(numb3 > maxnum)
{
    maxnum = numb3;
}

Console.WriteLine("Ваше максимальное число равно : " + maxnum);




//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Проверим, является ваше число четным или нет");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
   Console.WriteLine(" ДА ");
}   
else
{
    Console.WriteLine(" НЕТ ");
}




//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Получение списка четных чисел от 1 до заданного числа");
Console.Write("Введите число > 0: ");
int N = Convert.ToInt32(Console.ReadLine());
int counte = 1;

while(counte <= N)
{
    if(counte % 2 == 0)
    {
    Console.Write(counte + " ");
    }
    counte++;
}




