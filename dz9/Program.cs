/*
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void ShowNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1);
    if (num < 1) ShowNum(num + 1);  
}
Console.Write("input a number: ");
int n = Convert.ToInt32(Console.ReadLine ());
ShowNum(n);
*/
/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNumbers(int m, int n)
{
   
    if(m > n) return SumNumbers(m - 1, n) + m;
    if(m < n) return SumNumbers(m + 1, n) + m;
   else return n;
}
Console.Write("input a number: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine($"Sum of elements {m} + {n} =  {SumNumbers(m,n)}");
*/
/*
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman((m - 1), Akkerman(m, n - 1));
}
Console.Write("input a number: ");
int m = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a number: ");
int n = Convert.ToInt32(Console.ReadLine ());
 Console.WriteLine(Akkerman(m,n));
 */
