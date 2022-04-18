/*
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее



Console.WriteLine("input integer number");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int max;
int min;

if  (a > b)
{
       max = a;
       min = b;
       Console.WriteLine("number max " + max);
       Console.WriteLine("number min " + min);
}
if     (b > a)
{
       min = a;
       max = b;
       Console.WriteLine("number max " + max);
       Console.WriteLine("number min " + min);
}



// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("input integer numbers");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b)
   max = a;
else
{
   max = b;     
}
if (c > max)
   max = c;
   Console.WriteLine("Maximum number " + max);



// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("input integer number");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
   Console.WriteLine("an even number");
}
else
   Console.WriteLine("the number is odd");

 

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("input integer number");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if (num < 0)
{
        current = num;
        num = num *(0);
       Console.WriteLine("incorrect number");
}
else  
{
      current = 0;    
}
while(current <= num)
{
       Console.Write(current + " " );
       current = current + 2;
}
*/



       

   








