using ChallengeApp;

var employee1 = new Employee1("Janek", "Nowak");
employee1.AddGrade("Janek");
employee1.AddGrade(2);
employee1.AddGrade(4000);
employee1.AddGrade(6);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");