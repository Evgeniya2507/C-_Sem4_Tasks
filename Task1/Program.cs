/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Exponentiation();

int ReadInt(string argument)
{
    System.Console.Write($"Введите число {argument}: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

void Exponentiation()
{
    int A = ReadInt("A");
    int B = ReadInt("B");
    int extent = 1;
    int result = 1;

    while (extent <= B)
    {
        result = result * A;
        extent++;
    }
    System.Console.WriteLine(result);
}