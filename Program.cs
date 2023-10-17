namespace NumbersGame
{
    class Program
    {
        internal static void Main()
        {
            Random _random = new Random();
            int RandomNumber = _random.Next(1, 20);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            for (int i = 0; i < 5; i++)
            {
                int Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < RandomNumber)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else if (Guess > RandomNumber)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }
                else
                {
                    Console.WriteLine("Wohoo! Du klarade det!")
                }
            }

        }
    }
}