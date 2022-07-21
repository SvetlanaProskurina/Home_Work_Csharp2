/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("введите число");
int inPut  = Convert.ToInt32(Console.ReadLine());

void function (int input)
{
    for (int i=1; i<=input; i++)
    {
        Console.Write(Math.Pow(i,3));
        Console.Write(" , ");
    }

}
function (inPut);