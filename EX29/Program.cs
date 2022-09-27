// Напишите метод, который формирует массив из 8 
// случайных элементов и выводит их на экран.
using static System.Console;
Clear();
int[] array = GetArray(8);
PrintArray(array);





int[] GetArray(int lenght)
{
    int[] result=new int[lenght];
    for(int i=0;i<lenght;i++)
    {
        result[i]=new Random().Next(0,10);
    }
    return result;
}
void PrintArray(int[] inArray)
{
    Write("[");
for(int i=0;i<inArray.Length-1;i++)
{
    Write($"{inArray[i]}, ");
}
WriteLine($"{inArray[inArray.Length-1]}]");
}