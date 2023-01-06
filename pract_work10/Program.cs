// 10. Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую
// цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 ->1

Console.WriteLine("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string array = Convert.ToString(Number);

Console.WriteLine("Второе число: " + array[1]);
