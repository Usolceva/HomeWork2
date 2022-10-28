/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int CutNumber (int number)
{
    int sot = number % 100;
    number = sot / 10;
    return number;
}
Console.WriteLine("Input a thredigit number");
int num = Convert.ToInt32(Console.ReadLine ());
int result = CutNumber(num);
Console.WriteLine($"second figure of number {num} : {result}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 int ThreDigit(int number) 
{
       if (number < 100)
         return number = 0;
while (number > 100)
{
if (number > 99 && number < 1000)
{
     number %= 10;  
     break;     
}
else
{
     number /= 10;   
}
}
    return number;    
}
 
Console.WriteLine("Input a random number");
int num = Convert.ToInt32(Console.ReadLine ());
int res = ThreDigit(num);
Console.WriteLine($"thre figureis of number {num} : {res}");
*/


/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool DayOfWeek(int number)
{
if (number == 6 || number == 7)
{
return true;
}
else
{
return false;
}
}
Console.WriteLine("Input a number day of the week ");
int day = Convert.ToInt32(Console.ReadLine ());
bool res = DayOfWeek (day);
Console.WriteLine($"weekend {res}");
*/
