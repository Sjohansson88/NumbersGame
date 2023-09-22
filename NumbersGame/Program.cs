using System;

class Program
{
    static void Main()
    {
        static bool CheckGuess(int guess, int number)
        {
            return guess == number;
        }
        {
            Random random = new Random();
            int number = random.Next(1, 21);
            int attempts = 5;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1-20. Kan du gissa vilket? Du får fem försök");
          

            for (int i = 0; i < attempts; i++)
            {
                Console.Write("Gissa ett tal: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (CheckGuess(guess, number))
                {
                    Console.WriteLine("Woho! Du gjorde det!");
                    return;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Du gissade för lågt. Du har " + (attempts - i - 1) + " försök kvar.");
                }
                else
                {
                    Console.WriteLine("Tyvärr du gissade för högt! Du har " + (attempts - i - 1) + " försök kvar");
                }
                
            }

            Console.WriteLine("Tyvärr, du lyckades inte gissa talet på 5 försök");
        }
    }
}