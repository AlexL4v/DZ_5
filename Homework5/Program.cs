//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*int[] massiv;
int l = new Random().Next(5, 10);
massiv = new int[l];
for (int i = 0; i < l; i++) 
{
    massiv[i] = new Random().Next(100, 1000);  
    Console.Write(massiv[i] + " ");      
    
}   
Console.WriteLine();
int count = 0;
for (int i = 0; i < l; i++) 
{
    if (massiv[i]%2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве {count}");


// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] massiv;
int l = new Random().Next(3, 10);
massiv = new int[l];
for (int i = 0; i < l; i++) 
{
    massiv[i] = new Random().Next(-10, 10);  
    Console.Write(massiv[i] + " ");      
    
}   
Console.WriteLine();
int sum = 0;
for (int i = 0; i < l; i++) 
{
    if (i%2 != 0)
    {
        sum = sum + massiv[i];
    }
}

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве {sum}");

// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Вариант 1 тип int
Console.WriteLine("Введите число в диапазоне от 5 до 10 ");

int l = Convert.ToInt32(Console.ReadLine()); 
if (l<5 || l>10) 
{
    Console.WriteLine("Заданное число не сооветсвует условиям ");
    
} 
else 
{
    int[] arr;
    arr = new int[l];
    for (int i = 0; i < l; i++) 
    {
        arr[i] = new Random().Next(1, 100);  
        Console.Write(arr[i] + " ");      
    
    }   
    Console.WriteLine();
    int max = arr[l-1];
    int min = arr[l-1];
    for (int i = 0; i < l; i++) 
    {   
        if (arr[i] > max) 
        {
            max = arr[i];
        }
        if (arr[i]< min)
        {
            min = arr[i];
        }
        
    }
        Console.WriteLine("max = " + (max));
        Console.WriteLine("min = " + (min));
        Console.WriteLine("Разница " + (max - min));
}   
*/

// 2 вариант тип double
Console.WriteLine("Введите число в диапазоне от 5 до 10 ");

int l = Convert.ToInt32(Console.ReadLine()); 
if (l<5 || l>10) 
{
    Console.WriteLine("Заданное число не сооветсвует условиям ");
    
} 
else 
{
    double[] arr;
    arr = new double[l];
    for (int i = 0; i < l; i++) 
    {
        arr[i] = new Random().NextDouble();  
        Console.Write(arr[i] + " ");      
    
    }   
    Console.WriteLine();
    double max = arr[l-1];
    double min = arr[l-1];
    for (int i = 0; i < l; i++) 
    {   
        if (arr[i] > max) 
        {
            max = arr[i];
        }
        if (arr[i]< min)
        {
            min = arr[i];
        }
        
    }
        Console.WriteLine("max = " + (max));
        Console.WriteLine("min = " + (min));
        Console.WriteLine("Разница " + (max - min));
} 
