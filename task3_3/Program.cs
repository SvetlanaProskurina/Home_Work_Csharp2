/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("введите координаты 1 точки");
string[] point1 = Console.ReadLine().Split(',');
Console.WriteLine("введите координаты 2 точки");
string[] point2 = Console.ReadLine().Split(',');

double funcDistanse(string[] point1,string[] point2)
{
int [] array1 = new int [point1.Length];
int [] array2 = new int [point2.Length];
double distanse=0;

for (int i=0 ;i<point1.Length ;i++ )
{ 
array1[i] = int.Parse(point1[i].ToString());
}
for (int i=0 ;i<point2.Length ;i++ )
{ 
array2[i] = int.Parse(point2[i].ToString());
}
for (int i=0 ;i<point1.Length ;i++ )
{ 
distanse=distanse+Math.Pow((array2[i]-array1[i]),2);
}
double result = Math.Round(Math.Sqrt(distanse),2);
return result;
}
//Console.WriteLine(Math.Sqrt(distanse));
Console.WriteLine(funcDistanse(point1,point2));
