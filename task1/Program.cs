
Console.WriteLine("введите число");
int input  = Convert.ToInt32(Console.ReadLine());

string number = input.ToString();
//Console.WriteLine(number);
int [] array = new int[number.Length]; // создаем новый массив длинной равной количеству символов в строке
for (int i=0; i<number.Length; i++)
{
    array[i] = int.Parse(number[i].ToString()); //Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком
// Console.WriteLine(array[i]);
}
Console.WriteLine(array[1]);