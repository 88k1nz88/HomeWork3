﻿/* 
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear ();

Console.Write ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int range = number.Length;

if (range == 5)
{
    if (number[0] == number [4] && number [1] == number [3])
    {
        Console.WriteLine ($"Да, {number} это палиндром");
    }
    else 
    {
        Console.WriteLine ($"Нет, {number} это не палиндром!");
    }
}
else
{
    Console.WriteLine ("Отставить! Вы ввели не 5-ти значное число!");
}
