using System;

namespace BooleanExerciseStep94
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do While Loop

            Console.WriteLine("Let's play a game.");
            Console.WriteLine("I'm thinking of a color. Go ahead and take a guess, if you're wrong you'll get a hint!");
            string color = Console.ReadLine();
            bool isCorrectColor = false;

            do
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("You guessed red. That's not the color. The color I'm thinking of is on the opposite side of the spectrum! Try again.");
                        color = Console.ReadLine();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Wrong. While orange is associated with Halloween, this color is associated with a bigger holiday... Try again.");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. That's close to the color I'm thinking of on the color wheel! Try again.");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green! Yay! That is correct!");
                        isCorrectColor = true;
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. When people think of blue, they usually think of the sky or the sea. The color I'm thinking of is associated with nature too. But more directly! Try again.");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. If you combine purple with the color I'm thinking of it might make you think of Mardi Gras! Try again.");
                        color = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You guessed a color I don't even know! Good for you! Maybe try a guess that's more... within the rainbow.");
                        color = Console.ReadLine();
                        break;
                }
            } while (!isCorrectColor);

            //While Loop

            Console.WriteLine("Let's play a game.");
            Console.WriteLine("I have a pet animal. Go ahead and take a guess of what kind of pet! If you're wrong you'll get a hint!");
            string pet = Console.ReadLine();
            bool isCorrectPet = false;

            while (!isCorrectPet)
            {
                switch (pet)
                {
                    case "dog":
                        Console.WriteLine("You guessed dog. That's right! Of course it is! They are the greatest.");
                        isCorrectPet = true;
                        break;
                    case "cat":
                        Console.WriteLine("You guessed cat. If this is your favorite pet, I feel a little bad for you. My pet is MUCH better. That's your hint. Guess again.");
                        pet = Console.ReadLine();
                        break;
                    case "bird":
                        Console.WriteLine("Who even has a bird? I mean honestly. You can't cuddle with a bird! You can cuddle with my pet... Guess again.");
                        pet = Console.ReadLine();
                        break;
                    case "snake":
                        Console.WriteLine("NOPE. The pet I have is a mammal. Not the spawn of satan. Guess again.");
                        pet = Console.ReadLine();
                        break;
                    case "horse":
                        Console.WriteLine("Horses are chill I guess, so I don't hold it against you for guessing that. My pet is smaller and usually fluffier! Guess again.");
                        pet = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You went a little out there with the guesses, huh? Try again. I don't have a hint for you.");
                        pet = Console.ReadLine();
                        break;
                }
            }
            Console.Read();
        }
    }
}