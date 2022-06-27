// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int ThirdNumber()

{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Your number :" + num);

    int endnumber = num % 10;
    
    return(endnumber);
}

int result = ThirdNumber();
Console.WriteLine(result);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void ThirdPresence(int number)

{

if(10 <= number  && number <=99)
{
    Console.WriteLine("There is no third digit in your number!!!");
}

if(1000 <= number && number <= 9999)
{
    int dig = (number/10)% 10;
    Console.WriteLine(dig);
}
if(100 <= number && number <=999)
{
    int digit = number % 10;
    Console.WriteLine(digit);
}

if(10000 <= number && number <= 99999)
{
    int digi = (number/100)% 10;
    Console.WriteLine(digi);
}
   
}

Console.Write("Please, enter your number : " );
int numb = Convert.ToInt32(Console.ReadLine());

ThirdPresence(numb);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Holliday(int date)
{
    if(date < 6){
    Console.WriteLine("Go to work!!!");
    }
    if(6<= date && date <=7){
        Console.Write("RELAX, Holliday!!!");
    }
}
Console.Write("Enter the number of the day of the week : ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

Holliday(DayNumber);
