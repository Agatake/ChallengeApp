using ChallengeApp;

Employee employee1 = new Employee("Janek","Nowak",20);
Employee employee2 = new Employee("Zuzia","Kowalska",21);
Employee employee3 = new Employee("Ala","Malinowska",22);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);

employee2.AddScore(-4);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(-9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees) 
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee; 
    }
}
Console.WriteLine("wygrywa");
Console.WriteLine(employeeWithMaxResult.name + "");
Console.WriteLine(employeeWithMaxResult.surname + "");
Console.WriteLine(employeeWithMaxResult.age + "" + "lata");
Console.WriteLine("ilość punktów");
Console.WriteLine(maxResult);
Console.WriteLine("GRATULUJEMY!");