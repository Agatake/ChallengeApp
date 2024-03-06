var name = "Ewa";
var sex = "female";
var age = 30;
if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "female" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
