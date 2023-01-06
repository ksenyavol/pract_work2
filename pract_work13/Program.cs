// 13. Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 1000)
{
    int digit1 = number % 10;
    Console.WriteLine(digit1);
}

else if (number > 1000)
{
    int digit2 = number % 1000;
    int digit3 = digit2 / 100;
    Console.WriteLine(digit3);    
}
else if (number < 100)

{
    Console.WriteLine("Третьей цифры нет");
}
