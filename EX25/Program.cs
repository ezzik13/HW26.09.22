// Напишите метод, который принимает 
// на вход два числа (A и B) и возводит число 
// A в натуральную степень B с использованием цикла.

using static System.Console;
Clear();
WriteLine("Введите число A: ");
int A = Convert.ToInt32(ReadLine()!);
WriteLine("Введите степень B: ");
int B = Convert.ToInt32(ReadLine()!);
int AvStpeniB = GetPow(A, B);
WriteLine($"Число {A} в степени {B} равнo: {AvStpeniB}");

int GetPow(int number, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        result = result * number;
    }
    return result;
}