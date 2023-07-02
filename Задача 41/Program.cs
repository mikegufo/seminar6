// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void FillArray()
{
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine("Количество положительных чисел: " + string.Join(", ", count));
} 

System.Console.WriteLine("Введите числа: ");
FillArray();
