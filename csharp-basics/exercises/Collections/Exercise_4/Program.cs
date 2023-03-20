List<string> result = new List<string>();

Console.WriteLine("Write people names, then return");
var name = Console.ReadLine();

while (!string.IsNullOrEmpty(name))
{
    result.Add(name);
    name = Console.ReadLine();
}

result = result.Distinct().ToList();

Console.WriteLine("Unique names:");
Console.WriteLine(string.Join(",", result));