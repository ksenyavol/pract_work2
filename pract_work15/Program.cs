﻿// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
int index = 0;
while(index <= 10)
{
    if(DayNumber <= 5)
    {
        Console.WriteLine("Будний день");
        break;
    }
    
    else if(DayNumber > 5 && DayNumber <= 7)
    {
       Console.WriteLine("Выходной день");
       break;
    }
    else if(DayNumber > 7)
    {
        Console.WriteLine("Ошибка, такого дня нет");
    }
    index++;
}