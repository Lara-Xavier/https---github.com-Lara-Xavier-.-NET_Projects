// See https://aka.ms/new-console-template for more information
// This is the beginning of the Exercise3 class
public class Exercise3
{
    // This is the main method where the program execution starts
    
  static void Main(string[] args) //to create a main method 
        {
            Random random = new Random(); // creates a new instance of the Random class named random.
            bool playAgain = true;
            int min = 1;        
            int max = 100;
            int guess;          //variable to store the user guess
            int number;         //variable to store the random integer value
            int guesses;        //for how many guesses it took
            String response;    //User response Y/N 

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1); //generates a random integer between min and max

                //the player keeps guessing until they correctly guess the number.

                while (guess != number)             //check guess is not equal to the value of number
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)             //check user guess
                                                    // this code indicate to give hint for the user
                    {
                        Console.WriteLine(guess + " is to high!");
                        
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;            //if guess equals number we escape the while loop and we do need to increment our guesses by one
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);          //Display how many guesses it took

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
        }
}