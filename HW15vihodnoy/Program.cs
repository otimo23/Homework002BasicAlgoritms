Console.Clear();
int day = new Random().Next(1, 8);
if (day == 6 || day == 7)
{
    Console.WriteLine($"Day {day} is weekend!");
}
else
{
    Console.WriteLine($"Day {day} is weekday:(");
}

