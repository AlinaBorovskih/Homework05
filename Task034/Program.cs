/// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int [] mass = new int [4];
int summOdd = 0;
int summEven = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(100, 999);
}

for (int i = 0; i < mass.Length; i++ )
{
Console.WriteLine($"{mass[i]} ");
}

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 == 1)                                 
    { 
       summOdd = summOdd + 1;
    }
else
{
 summEven = summEven + 1;
} 
}
Console.WriteLine($"Колличество четных чисел равно {summEven}");