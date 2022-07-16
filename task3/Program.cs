Console.WriteLine("введите число");
int inPut  = Convert.ToInt32(Console.ReadLine());
void function (int input)
{
    if (input==6 || input == 7)
    {
        Console.WriteLine(input + " -> да, этот день недели является выходным");
    }
else if (input>7) 
{
 Console.WriteLine("В неделе 7 дней, введите число от 1 до 7");
}
else Console.WriteLine(input + " -> нет, этот день недели является будним днём");
}

function(inPut);