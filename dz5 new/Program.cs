//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*метод генерации массива положительными трёхзначными числами.
int[] CreateRandomArray(int size)
{
    int[] arrey = new int[size];
    for(int i = 0;  i < size; i++)
        arrey[i] = new Random().Next(100, 1000);

    return arrey;
}
*/
//метод для вывода массива
/*void ShowArrey(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
int EvenNumbers(int[] array)
{
int current = 0;
for(int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
     current++;
return current;
}
Console.Write("input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine ());
int[] myArray = CreateRandomArray(n);
ShowArrey(myArray);
Console.WriteLine("the number of even numbers in the array: " + EvenNumbers(myArray));
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] arrey = new int[size];
    for(int i = 0;  i < size; i++)
        arrey[i] = new Random().Next(minValue, maxValue + 1);

    return arrey;
}

int SumEven(int[] array)
{
int sum = 0;
for(int i = 1; i < array.Length; i += 2)
 sum += array[i];
return sum;
}
Console.Write("input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine ());
Console.Write("input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine ());
int[] myArray = CreateRandomArray(n,min, max);
ShowArrey(myArray);
Console.WriteLine("sum of odd elements " + SumEven(myArray));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0;  i < size; i++)
       array[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 3);
    return array;
}

void ShowArrey(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

double MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diffirence = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
        max = array[i];
        
         if (array[i] < min)
        
        min = array[i];
        }
    }
     diffirence = max - min;
     Console.WriteLine($"max number = {max}; min number = {min}");
     return diffirence;
}
Console.Write("input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(n, min, max);
ShowArrey(myArray);
Console.WriteLine(" diffirence of elements " + MaxMin(myArray));