// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



/*int[] array = GetArray(15,100,999);
Console.Write($"[{String.Join(",", array)}]");

int count = 0;
foreach (int el in array)
{
    if (el % 2 == 0)
    {
        count++;
    }
}
Console.Write($"->{count}");

//------Метод-------
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

/*int[] array = GetArray(15);
int sum = 0;   
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum += array[i];
    }
        
}
    


Console.Write($"[{String.Join(", ", array)}] -> {sum}");

int[] GetArray (int size)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0,100);
    }
    return res;
}*/

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] array = GetArray(5,0,10);
Console.Write($"-> [{String.Join(", ", array)}]");

int [] arraySum (int[] array)
{
int  size = array.Length / 2;
if (array.Length % 2 == 1) size++;
int [] res = new int[size];
for (int i = 0; i < array.Length / 2; i++)
{
   res[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 == 1) res[size - 1] = array[array.Length / 2];
return res;
}
Console.Write($"-> [{String.Join(", ", arraySum(array))}]");

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
