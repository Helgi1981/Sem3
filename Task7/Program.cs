// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементами массива. 

double[] numbers = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };

double max = numbers[0];
double min = numbers[0];
// int maxIndex = 0;
// int minIndex = 0;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
        // maxIndex = i;
    }

    if (numbers[i] < min)
    {
        min = numbers[i];
        // minIndex = i;
    }
}

double variance = max - min;

Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + variance);
