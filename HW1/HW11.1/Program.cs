using System;

class Program
{
    static void Main()
    {
        string secretWord = "dolphin";
        char[] guessedWord = new string('_', secretWord.Length).ToCharArray();
        char[] guessedLetters = new char[32];
        int guessedCount = 0;
        int attemptsLeft = secretWord.Length;

        Console.WriteLine("Welcome! Try to guess the hidden word!");
        Console.WriteLine($"Number of letters in the word: {secretWord.Length}");
        Console.WriteLine($"Number of allowed incorrect attempts: {attemptsLeft}\n");

        while (attemptsLeft > 0 && new string(guessedWord) != secretWord)
        {
            Console.Write("Enter your letter: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            bool alreadyGuessed = false;
            for (int i = 0; i < guessedCount; i++)
            {
                if (guessedLetters[i] == input)
                {
                    alreadyGuessed = true;
                    break;
                }
            }

            if (alreadyGuessed)
            {
                Console.WriteLine("You already entered this letter! Try another one.");
                continue;
            }

            guessedLetters[guessedCount++] = input;

            if (secretWord.Contains(input))
            {
                Console.Write("This letter is in the word! Letter position: ");
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == input)
                    {
                        guessedWord[i] = input;
                        Console.Write((i + 1) + " ");
                    }
                }
                Console.WriteLine("\nCurrent word state: " + new string(guessedWord));
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine($"This letter is not in the word! Attempts left: {attemptsLeft}");
            }
        }

        if (new string(guessedWord) == secretWord)
        {
            Console.WriteLine("\nCongratulations, you guessed the word! The hidden word: " + secretWord);
        }
        else Console.WriteLine("\nYou lost! The hidden word was: " + secretWord);
    }
}
