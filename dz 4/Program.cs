/*
// 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Degree (int a, int b)
{
    int natural = 1;
    for(int i = 1; i <= b; i ++)
    {
        natural *= a;
    }
    return natural;
}
Console.WriteLine("Input a number: A ");
int A = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Input a number: B ");
int B = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine($"A в степени B = {Degree(A, B)}");
*/
/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum(int num)
{
int sum = 0;
while (num != 0)
 {
   int i = num % 10;
    num = num / 10;
    sum += i;
 }
 return sum;
}

Console.WriteLine("Input a number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {A} = {Sum(A)} ");
*/
/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Попробовала решить, вот что получилось))
//функцию взяла с лекции, не могу понять почему выдает ошибку что тело не объявлено?
//и ошибка не существует в текущем контексте arrey?
//Не знаю какой командой сделать ввод массива пользователем. 
void PrintArrey (int [] arrey);
{
    int count = arrey.Length;
    for(int i = 0; i < count; i++)
    {
       Console.WriteLine($"{arrey [i]}");
    }
}
PrintArrey(arr);
*/
