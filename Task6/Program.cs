// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

using System.Reflection;

int[] array = new int[10] { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
int result = 0; // Переменная для хранения количества четных чисел

// Решение с циклом foreach:

foreach (int num in array)
{
    if (num % 2 == 0)
    {
        result++;
    }
}
Console.WriteLine("Количество чётных чисел в массиве: " + result);



// Решение с циклом for:

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         result++;
//     }
// }
// Console.WriteLine("Количество чётных чисел в массиве: " + result);



// Решение с выводом всех чётных чисел, в строчку, через запятую:

// // Выводим заголовок
// Console.Write("Чётные числа массива: ");

// // Флаг для определения, было ли уже выведено хотя бы одно четное число
// bool isFirstEven = true;

// foreach (int num in array)
// {
//     if (num % 2 == 0)
//     {
//         // Если это первое четное число, то не добавляем запятую перед ним
//         if (!isFirstEven)
//         {
//             Console.Write(", ");
//         }
//         Console.Write(num);
//         isFirstEven = false;
//     }
// }
// Console.WriteLine(); // Переход на новую строку после вывода всех четных чисел
