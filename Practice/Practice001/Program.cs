int quad, num;
Console.Write("Введите число : ");
num = Convert.ToInt32(Console.ReadLine());
quad = num * num;
Console.WriteLine("Квадрат вашего числа равен: " + quad);


//Задача №3
int num1, result;
Console.Write("Введите трехзначное число : ");
num1 = Convert.ToInt32(Console.ReadLine());
result = num1 % 10;

Console.WriteLine("Последнее число это :" + result);

//Вывод чисел

int current;
Console.Write("Введите число : ");
 int number = Convert.ToInt32(Console.ReadLine());

 if (number < 0)
 {
    number = number * (-1);
 }

current = number * (-1);

while(current <= number)
{
    Console.Write(current + " ");
    current++;
} 
