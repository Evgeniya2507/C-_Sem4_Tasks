/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Sum();

int ReadInt()
{
    System.Console.Write("Введите число: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

void Sum()
{
    int x = ReadInt();
    int result = 0;
    while (x > 0)
    {
        int digit = x % 10;
        result = result + digit;
        x = x / 10;
    }
    System.Console.WriteLine(result);
}

