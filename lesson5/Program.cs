// Задача 1
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
/*
 void Array ()
{
    int[] n = new int[12];
    int pos =0, neg = 0;
    for (int i = 0; i<12; i++)
    {
        n[i] = new Random().Next(-9,10);
        
        Console.Write(n[i] + " ");
        
        if (n[i]>0)
        {
            pos = pos + n[i];
        }
        else neg = neg + n[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов заданного массива равна {pos} ");
    Console.WriteLine($"Сумма отрицательных элементов заданного массива равна {neg} ");
}
Array();


// Задача 2 Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
 void Array ()
{
    int[] n = new int[12];
        for (int i = 0; i<12; i++)
    {
        n[i] = new Random().Next(-9,10);
        
        Console.Write(n[i] + " ");
                
    }
    Console.WriteLine();
    for (int i = 0; i < 12; i++)
        {
            n[i]=n[i]*(-1) ;
            Console.Write(n[i] + " ");

        }
}
    Array();


    // Задача 3 Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

int[] arr = new int[33];
int count =0;
for (int i = 0; i < 33; i++)
{
    arr[i] = new Random().Next(1, 34);  
    Console.Write(arr[i] + " "); 
}
Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 33; i++)
{
    if (arr[i]== number) 
    {
        Console.WriteLine("Данное число является элементом массива");
        count = 1;
        break;
    }
    
    
}
if (count == 0) Console.WriteLine("Данное число не является элементом массива");





// Задача 4 Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + " ");
}
for (int i = 0; i < 123; i++)
{
    if(array[i]>=10 && array[i]<=99)
    {
        count ++;
    }
    
    
}
Console.WriteLine();
  Console.WriteLine($"Массив содержит {count} элементов, находящихся отрезке от 10 до 99");
*/
// Задача 5 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


int[] massiv;
int l = new Random().Next(5, 15);
massiv = new int[l];
for (int i = 0; i < l; i++) 
{
    massiv[i] = new Random().Next(1,100);  
    Console.Write(massiv[i] + " ");      
    
}   
Console.WriteLine(); 
int[] array;
int length=1;
int a = l/2+length;
array = new int[a];
if (l/2 == 0) length =0;
  
    for (int i = 0; i < a; i++)
    {
        array[i] = massiv[i]*massiv[l-i-1];
        
        if(i == l-i-1) array[i] = massiv[i];
        Console.Write(array[i] + " ");
    }   


