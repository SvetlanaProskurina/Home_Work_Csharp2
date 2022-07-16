Console.WriteLine("введите число");
int inPut  = Convert.ToInt32(Console.ReadLine());
void function (int input)
{
string number = input.ToString();
//Console.WriteLine(number);
int [] array = new int[number.Length]; // создаем новый массив c элементами типа INT и длинной равной количеству символов в строке
for (int i=0; i<number.Length; i++)
{
    array[i] = int.Parse(number[i].ToString()); //Преобразует строковое представление числа в эквивалентное ему целое число 
// Console.WriteLine(array[i]);
}
if (number.Length>=3) {
Console.WriteLine(array[2]);
}
else Console.WriteLine("третьей цифры в числе " + input + " нет");
}
function (inPut);