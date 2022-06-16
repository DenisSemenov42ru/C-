Console.WriteLine("Здравствуйте, введите ваше имя: ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.WriteLine(username);
// Write - команда для вывода в одну строку
// Write.Line - команда для вывода и перехода на следующую строку
// Read.Line - команда для считывания данных введеных в терминал


Console.WriteLine("Теперь давай посчитаем сумму чисел!");
int numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
// new Random().Next(Интервал) - команда генерирующая случайное число в указанном интервале
// int - тип для целых чисел
// double - тип для чисел с плавающей запятой
// + сложение
// - вычитание
// * умножение
//  /  деление
// () приоритет
// % остаток от деления

Console.WriteLine("Теперь давай изучать условия IF--Else");
Console.WriteLine("Здравствуйте, введите ваше имя: ");
string usernameA = Console.ReadLine();

 if(usernameA.ToLower() == "денис") 
 {
    Console.WriteLine("Привет, кожаный ублюдок!!! ");
 }
 else 
 {
    Console.Write("Привет, ");
    Console.WriteLine(usernameA);
 }


 Console.WriteLine("Ну а теперь давай познакомимся с циклами. Если ты не хочешь делать этого непиши 'нет', а если ты еще не устал напиши 'ДА' ");
 string answer = Console.ReadLine();

if(answer.ToLower() == "нет")
    {
        Console.WriteLine("Пока, ЛЕНИВАЯ ЗАДНИЦА");
    }
if(answer.ToLower() == "да") 
     {
        Console.Clear();

        int xa = 40, ya = 1,
            xb = 1, yb = 30,
            xc = 80, yc = 30;

        Console.SetCursorPosition(xa, ya);
        Console.WriteLine("+");

        Console.SetCursorPosition(xb, yb);
        Console.WriteLine("+");

        Console.SetCursorPosition(xc, yc);
        Console.WriteLine("+");

        int x = xa, y = ya;

        int count = 0;

        while (count < 10000)
        {
            int what = new Random().Next(0, 3);
            if (what == 0)
            {
                x = (x + xa) / 2;
                y = (y + ya) / 2;
            }

            if (what == 1)
            {
                x = (x + xb) / 2;
                y = (y + yb) / 2;
            }
            if (what == 2)
            {
                x = (x + xc) / 2;
                y = (y + yc) / 2;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine("+");
            count++;
        }

     }  
