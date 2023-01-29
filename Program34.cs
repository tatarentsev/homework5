// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Random_Array ()
{
    int index = 0;
    int[] collection = new int [900];
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }

    int count = 0; 
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }
    } 
    return count; 
}

Console.WriteLine(Random_Array());


// Проверка, вывод 2

// int Random_Array ()
// {
//     int[] collection = {345, 897, 568, 234};
//     int count = 0; 
//     for (int i = 0; i < collection.Length; i++)
//     {
//         if (collection[i] % 2 == 0)
//         {
//             count++;
//         }
//     } 
//     return count; 
// }

// Console.WriteLine(Random_Array());
