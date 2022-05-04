// //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

double [] mass = new double [5];
double max = 0;
double min= 0;
double result = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(0, 100);
}
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"{mass[i]} ");
}

max = mass[0];
min = mass[0];

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
     max = mass[i];   
    }
    if (mass[i] <= min)
    {
    min = mass[i];
    }
}
result = max - min;

Console.WriteLine($"Разница {result} между максимальным {max} и минимальным {min} элементом массива");