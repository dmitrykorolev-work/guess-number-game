namespace ConsoleApp20;

class Program
{
    static void Main(string[] args)
    {
        int randomMin = 0;
        int randomMax = 64;

        int maxAttempts = (int) Math.Ceiling(Math.Log2(randomMax));

        int magicNumber = new Random().Next(randomMin, randomMax);

        int attempts = maxAttempts;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to guess number game");
        Console.ResetColor();

        while (attempts >= 1)
        {
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == magicNumber)
            {
                if (attempts == maxAttempts)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Congratulations! You guessed the number on your first try!");
                    Console.ResetColor();
                    break;
                } else{
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations! You guessed the number in {maxAttempts - attempts + 1} attempts!");
                    Console.ResetColor();
                    break;
                }
            }

            attempts--;

            if (attempts == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game over");
                Console.ResetColor();
                break;
            }
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Try again... (attempts: {attempts})");

            string clue = x > magicNumber ? "less" : "higher";
            Console.WriteLine($"The hidden number is {clue}");
            Console.ResetColor();
        }
    }
}