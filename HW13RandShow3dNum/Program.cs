Console.Clear();
int num = new Random().Next(0, 1000);
if(num > 99)
{
int thirdnumber = num % 10;
Console.WriteLine($"Third number of {num} is {thirdnumber}");
}
else
{
Console.WriteLine($"Third number of {num} does not exists");
}





/*Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет*/