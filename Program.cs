//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


/*Console.WriteLine("Enter number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A to the degree of B equal to : " + step);*/

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*Console.WriteLine("Enter number");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("the sum of all digits in the number is equal to: " + sum);*/


//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


/*int [] numbers = new int[8];
Console.Write("Аrray of numbers:");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 999);
    Console.Write(" " + Method (i) + " ");
 }
int Method (int a)

{
    return numbers[a];
}*/

