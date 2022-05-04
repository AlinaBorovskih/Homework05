// // Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int [] mass = new int [4];
int summ = 0;

for (int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(0, 30);
}
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"{mass[i]} ");
}
for (int i = 1; i < mass.Length; i+=2)
{
    summ = summ + mass[i];

}
Console.WriteLine($"Cумма нечетных позиций {summ}");