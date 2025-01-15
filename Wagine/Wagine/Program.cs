var names = new List<string>(){"Stas","Oleg","Alina" };

ShowNames(names);

names.Add("Damian");

ShowNames(names);

void ShowNames(List<string> names1)
{
    foreach (var name in names1)
    {
        if (name == "Alina")
        {
            Console.WriteLine($"{name} nie pidor");
        }
        else
        {
            Console.WriteLine($"{name} pidor");
        }
    } 
}