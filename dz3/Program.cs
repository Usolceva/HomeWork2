/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Palindrome(int num)
{
int pal = num;
int prom = 0;
while (num > 0)
{
    int ed = num % 10;
     prom = prom * 10 + ed;
     num /= 10;
}
if (pal == prom)
    return true;

else 
{
    return false;
}
}
Console.WriteLine("Input a five-digit number ");
int number = Convert.ToInt32(Console.ReadLine ());
bool res = Palindrome(number);
Console.WriteLine(res);
*/
/*
//21Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Teorema(double x1, double y1, double z1, double x2, double y2, double z2)
{
double cathet1 = x1 - x2;
cathet1 = Math.Pow(cathet1,2);
double cathet2 = y1 - y2;
cathet2= Math.Pow(cathet2,2);
double cathet3 = z1 - z2;
cathet3 = Math.Pow(cathet3,2);
double hypotinuza = cathet1 + cathet2 + cathet3;
double quarthypotinuza = Math.Sqrt(hypotinuza);
return quarthypotinuza;
}
Console.Write("Input the x coordinate of the first point: ");
int x1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Input the y coordinate of the first point: ");
int y1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Input the z coordinate of the first point: ");
int z1 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Input the x coordinate of the second point: ");
int x2 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Input the y coordinate of the second point: ");
int y2 = Convert.ToInt32 (Console.ReadLine());

Console.Write("Input the z coordinate of the second point: ");
int z2 = Convert.ToInt32 (Console.ReadLine());

double res = Teorema(x1, y1, z1, x2, y2, z2);
Console.WriteLine($" distance in 3D space {res}');
*/
/*
//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Qub(int n)
{
int current = 1;

while (current <= n)
{
    Console.Write($"{Math.Pow(current, 3)}, ");
    current ++;
}
return current;
}

Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());
int res = Qub(number);
Console.WriteLine(res);
*/ 


