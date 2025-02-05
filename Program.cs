class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        int num = new Random().Next(1, 101);

        Console.WriteLine("OK I Guessed the number");
        Console.WriteLine("Please select the difficulty level:\r\n1. Easy (10 chances)\r\n2. Medium (5 chances)\r\n3. Hard (3 chances)");

        Console.Write("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Great! You have selected the Easy difficulty level.");
                GuessNum(num, 10);
                break;
            case 2:
                Console.WriteLine("Great! You have selected the Medium difficulty level.");
                GuessNum(num, 5);
                break;
            case 3:
                Console.WriteLine("Great! You have selected the Hard difficulty level.");
                GuessNum(num, 3);
                break;
        }

    }

    private static void GuessNum(int num, int chances)
    {
        bool found = false;
        Console.WriteLine("Let's start the game!");
        for(int i = 0; i< chances; i++)
        {
            Console.Write("Enter your guess:");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == num)
            {
                found = true;
                Console.WriteLine($"Congratulations! You guessed the number in {i+1} attempts");
                return;
            }
            else if (guess < num)
            {
                Console.WriteLine("The number is greater than : " +guess);
            }
            else
            {
                Console.WriteLine("The number is less than : "+guess);
            }
        }
        if (!found)
        {
            Console.WriteLine("Sorry! You have exhausted all your chances.");
            Console.WriteLine("The number was: " + num);
        }
    }
}