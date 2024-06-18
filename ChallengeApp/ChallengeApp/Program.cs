using ChallengeApp;

var employee1 = new Employee1("Janek", "Nowak");
employee1.AddGrade("Janek");
employee1.AddGrade(2);
employee1.AddGrade(4000);
employee1.AddGrade(6);
var statistics = employee1.GetStatistics();
var statistics1 = employee1.GetStatisticsWithForEach();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithDoWhile();

Console.WriteLine("While");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");

Console.WriteLine("ForEach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min:N2}");
Console.WriteLine($"Max: {statistics1.Max:N2}");

Console.WriteLine("For");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min:N2}");
Console.WriteLine($"Max: {statistics2.Max:N2}");

Console.WriteLine("DoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min:N2}");
Console.WriteLine($"Max: {statistics3.Max:N2}");


