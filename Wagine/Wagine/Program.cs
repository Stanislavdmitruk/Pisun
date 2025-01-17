var tries = 0;

while (tries <= 3)
{
    Console.WriteLine("Name");

    var name = Console.ReadLine();

    Console.WriteLine("Password");

    var password = Console.ReadLine();

    if (name == "Stas" && password == "1313")
    {
        Console.WriteLine("All OK");
        break;
    }
    else
    {
        tries++;
        if (tries <= 3)
        {
            Console.WriteLine("Ebat ty debil"); 
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}
