
string name = "Ewa";
bool isWoman = false;
int age = 17;

if (isWoman == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age >= 30)
    {
        Console.WriteLine("Kobieta 30 i więcej lat");
    }
}
else if (!(isWoman == true) && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (isWoman == false && age >= 18)
{
    Console.WriteLine("Pełnoletni Mężczyzna");
}