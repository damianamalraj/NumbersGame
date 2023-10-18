namespace NumbersGame
{
    class Program
    {
        internal static void Main()
        {
            Random _random = new Random();
            int RandomNumber = _random.Next(1, 20);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            static void CheckGuess(int RandomNumber)
            {

                for (int i = 0; i <= 4; i++)
                {
                    int Guess = Convert.ToInt32(Console.ReadLine());
                    if (Guess != RandomNumber && i is 4)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                        return;
                    }
                    else if (Guess < RandomNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");
                    }
                    else if (Guess > RandomNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");
                    }
                    else
                    {
                        Console.WriteLine("Wohoo! Du klarade det!");
                        return;
                    }

                }
                Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
            }

            CheckGuess(RandomNumber);
        }
    }
}