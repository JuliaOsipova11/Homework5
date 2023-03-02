// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] RandomArray = new int[size];
//     for(int i = 0; i<size; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max+1);
//     }
//     return RandomArray;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int QuantityPositive(int[] array)
// {
//     int quantity = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) 
//         quantity ++;
//     }
//     return quantity;
// } 
// int [] myArray = new int [5];
// myArray = CreateRandomArray (5, 100, 999);
// ShowArray(myArray);
// Console.WriteLine($"Quantity of even numbers in array is " + QuantityPositive(myArray));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }
// void ShowArray (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int FindSum (int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum += array[i];
//     }
//     return sum;
// } 

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// Console.WriteLine("Sum of elements in array: {FindSum(myArray)}");
// FindSum(myArray);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int Find_Min_Max_diff(int[] array)
// {
//     int result = 0;
//     int min = 0;
//     int max = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[min] > array[i])
//         min = i;
//         else if (array[max] < array[i])
//         max = i;
//     }

//     if (array[min] > array[max])
//     result = array[min] - array[max];
//     else if (array[max] > array[min])
//     result = array[max] - array[min];
//     return result;
// }
// Console.Write("Enter size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Console.Write("Enter min number: ");
// int Min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max number: ");
// int Max = Convert.ToInt32(Console.ReadLine());
// int temp = 0;
//     if (Min > Max)
//         {
//         temp = Max;
//         Max = Min;
//         Min = temp;
//         }
// Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//     array[i] = rand.Next(Min, Max);
//     for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
            
// Console.WriteLine("Difference between minimum and maximum array element = " + Find_Min_Max_diff(array));

  