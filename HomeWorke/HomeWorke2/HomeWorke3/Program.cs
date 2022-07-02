//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polindrome(string number)
{
   if (number[0] == number[4] && number[1] == number[3])
   {
    Console.WriteLine("YES");
   }
   else
   {
    Console.WriteLine("NO");
   }
}

Console.Write("Введите пятизначное число: ");
string Number = Console.ReadLine();
Polindrome(Number);


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2 -z1)*(z2 -z1));
    return dist;
} 

Console.Write("Введите координату 'x' первой точки : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'y' первой точки : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'z' первой точки : ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'x' второй точки : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'y' второй точки : ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату 'z' второй точки : ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Distance = " + Distance(x1, y1, z1, x2, y2, z2)); 

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)

{
   if(num < 0) num = num *(-1);
    int i = 0;
   while(i < num){
     i++;
     Console.Write(i*i*i + " ");
    
   } 
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Cube(num);
