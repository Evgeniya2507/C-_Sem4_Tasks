/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int [] numbers = new int[8];
int length = numbers.Length;

void Array(int length)
{
    for ( int i = 0; i < length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
        System.Console.Write(numbers[i] + " ");
    }
}

Array(length);