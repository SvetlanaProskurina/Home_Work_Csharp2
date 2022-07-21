/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("введите число не больше 999 999 999");
int inPut  = Convert.ToInt32(Console.ReadLine());

bool function (int input)
{
    int length;
    string number = input.ToString();

int lengthInit = number.Length;

if (lengthInit%2==0)
{
    length=lengthInit/2;
}
else 
{
    length= lengthInit/2-1;
}
int [] array1 = new int[length]; // создаем новый массив c элементами типа INT и длинной равной количеству символов в строке
int [] array2 = new int[length];
bool returnn=false;
for (int i=0; i<length; i++)
    {
        array1[i] = int.Parse(number[i].ToString()); //Преобразует строковое представление числа в эквивалентное ему целое число 
        array2[i] = int.Parse(number[lengthInit-1-i].ToString());
  
        if (array1[i]!=array2[i] )
        {
            returnn=true;
        }
        else 
        {
            returnn=false;
        }
   
    }  
return returnn;
}

if (function(inPut) == true)
{
    Console.WriteLine("не паллиндром");
}
else Console.WriteLine("Паллиндром");