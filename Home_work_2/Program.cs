﻿/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int anyNamber = Convert.ToInt32(Console.ReadLine());
string anyNamberText = Convert.ToString(anyNamber);

if (anyNamberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + anyNamberText[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}