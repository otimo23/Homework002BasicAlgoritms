
Console.Clear();
Console.WriteLine("Write a number: ");
int num = int.Parse(Console.ReadLine()!);
if(num < 100){
    Console.WriteLine("No third number");
}else{
    while (num > 1000)
    num = num / 10;
    Console.WriteLine($"{num%10}"!);
}




/*Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет*/