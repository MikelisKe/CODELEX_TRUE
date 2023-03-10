var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

Console.WriteLine(string.Join(",",daysNames));

/*foreach (var d in daysNames)
{
    Console.Write($"{d} "); 
}*/

Console.ReadKey();
