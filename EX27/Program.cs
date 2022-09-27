// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
using static System.Console;
Clear();
WriteLine("Введите число A: ");
int A = Convert.ToInt32(ReadLine()!);
int sum = GetSum(A);
WriteLine($"Сумма цифр числ {A} = {sum}");

int GetSum(int number)
{
    int result = 0;
    if (number > 0)
    {
        while (number > 0)
        {
            result = result + number % 10;
            number = number / 10;
        }
    }
    else
    {
        while (number < 0)
        {
            result = result + number % 10;
            number = number / 10;
        }
    }

    return result;
}