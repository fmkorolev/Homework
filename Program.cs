﻿//Задание 1

int a;
int b;
int min;
int max;

Console.Write("Input first number : ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
b = Convert.ToInt32(Console.ReadLine());

if (a>b)
max = a;
else
max = b;

if(a<b)
min= a;
else 
min = b;

Console.WriteLine("Maximum number ={0}", max);
Console.WriteLine("Minimum number ={0}", min);






/*
//ЗАДАЧА 2//
// решил сделать текстовой вывод а не цифровой))

int num1, num2, num3;       
Console.Write("input first number : ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number : ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input third number : ");
num3 =  Convert.ToInt32(Console.ReadLine());
if (num1 > num2) 
{
    if (num1 > num3) 
{
    Console.Write("Number one is the largest!\n");
 } 
 else 
{
  Console.Write("Number three is the largest!\n");
}
}
    else if (num2 > num3)
Console.Write("Number two is the largest!\n");
else
Console.Write("Number three is the largest!\n");
*/

/*
//Задача 3
//Долго пытался и вроде как получилось))
int a;
Console.Write("Input number: ");
a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
Console.WriteLine("Is even");
}
else
{
    Console.WriteLine("Is odd");
   
}

*/
/*
// Задача 4
Console.Write("input number : ");
int num = Convert.ToInt32(Console.ReadLine()); 
for (int i = 1; i <= num; i++) 
{
    if (i % 2 == 0) 
 {
    Console.WriteLine(i);
}
}
*/