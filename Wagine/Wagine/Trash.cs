namespace Wagine;

public class Trash
{
    public int MaxTry { get; set; } = 3;
    public void TryLogin()
    {
        var tries = 0;

        while (true)
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
                if (tries <= MaxTry)
                {
                    Console.WriteLine("Ebat ty debil"); 
                }
                else
                {
                    Console.WriteLine("nie nu ty i koncz");
                    break;
                }
            }
        }

    }
}