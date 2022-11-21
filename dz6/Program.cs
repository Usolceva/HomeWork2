//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        {
            Console.Write("Input a number m: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Result(int[] array)
{
    int res = 0;
    for(int i = 0;  i < array.Length; i++)
      if (array[i] > 0)
    res += 1;
    return res;
}
Console.Write("Input a count number: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(m);
ShowArray(myArray);
Console.WriteLine($"Count number > 0: {Result(myArray)}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Coordinates(double k1, double b1, double k2, double b2)
{
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
 Math.Round(x, 3); Math.Round(y, 3);
 if (k1 != k2)
 {
     Console.WriteLine($" кординаты пересекаются: ({x} ; {y})");
 }
     if  (k1 == k2 && b1 != b2)
     {
         Console.WriteLine($" координаты паралельны: ({x} ; {y})");
     }
        if (k1 == k2 && b1 == b2) 
        {
           Console.WriteLine($"координаты совпадают: ({x} ; {y})");
        } 
}

Console.WriteLine("Input b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Coordinates(k1, b1, k2, b2);