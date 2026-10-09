using System;

Random random = new Random();
int targetNumber = random.Next(1, 101);

Console.WriteLine("Tere tulemast! Arva ära number 1 kuni 100.");

while (true)
{
    Console.Write("Sisesta oma pakkumine: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int userGuess))
    {
        if (userGuess < 1 || userGuess > 100)
        {
            Console.WriteLine("Palun sisesta number vahemikus 1-100.");
            continue;
        }

        if (userGuess == targetNumber)
        {
            Console.WriteLine("Õnnitleme! Arvasid õigesti!");
            break;
        }
        else if (userGuess > targetNumber)
        {
            Console.WriteLine("Arv on väiksem");
        }
        else
        {
            Console.WriteLine("Arv on suurem");
        }
    }
    else
    {
        Console.WriteLine("Palun sisesta kehtiv täisarv!");
    }
}