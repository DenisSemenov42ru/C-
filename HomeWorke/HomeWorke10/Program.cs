// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

// string[] Words = {"qwe", "wer", "ert", "rty", "tyu"};
// char[] Vowels = {'a',  'e', 'i', 'o', 'u', 'y'};

// int CountWords(string[] array, char[] arraycheck)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         for(int j = 0; j < arraycheck.Length; j++)
//         {
//             if(array[i][0] == arraycheck[j]) count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine(CountWords(Words,Vowels));

//Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

 string[] Qwer = {"qwe", "wer", "ert", "rty", "tyu","yui"};

 string[] SumWords(string[] array)
 {
    int count = array.Length / 2 ;
    string[] sum = new string[count];
     for(int i = 0; i < count; i++)
     {
        sum[i] = array[i * 2] + array[(i * 2) + 1];
     }
     return sum;
 }

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
ShowArray(SumWords(Qwer));




