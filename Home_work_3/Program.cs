﻿/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет 
*/

Console.WriteLine("Введите цифру, обозначающую день недели ");
int day = 0;
day = Convert.ToInt32(Console.ReadLine());

if(day == 6 || day == 7)
{
    Console.WriteLine(day + " -> Да");
}
else
{
    Console.WriteLine(day + " -> Нет");
}