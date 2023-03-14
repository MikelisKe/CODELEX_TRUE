var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

Console.WriteLine(string.Join(",",daysNames));

Console.ReadKey();
