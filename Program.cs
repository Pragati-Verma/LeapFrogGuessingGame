
Console.WriteLine("""
    Numeric Leapfrog - A Number Guessing Game:
    Get close to the number without going over. 
    Each guess is added to the previous guess.
    When you are within three or you go over, the game is over.
    Get close in as few guesses as possible without going over.
    """);

int currentValue,
    guessNextValue;
int maxNumber = Random.Shared.Next(1, 51);
int guessCount = 1;
bool isValid;

Console.WriteLine();
Console.WriteLine("Enter your first guess:");
string firstNumberText = Console.ReadLine() ?? "1"; //null check and assigns 1 as string if null 
int.TryParse(firstNumberText, out currentValue);

Console.WriteLine();

while(currentValue < maxNumber-3) 
{
    Console.WriteLine($"Your guess is {currentValue}. This is your #{guessCount} guess");
    guessCount++;
    Console.WriteLine();

    do
    {
        Console.WriteLine("Guess next number:");
        string nextNumberText = Console.ReadLine() ?? "1";
        isValid = int.TryParse(nextNumberText, out guessNextValue); 
    } while (isValid == false); //keeps on checking if any value other than number is entered

    currentValue += guessNextValue;
}
Console.WriteLine();

if (currentValue <= maxNumber)
    Console.WriteLine($"YOU WIN!!! The number was {maxNumber}. You guessed it in {guessCount} tr{(guessCount == 1 ? "y" : "ies")}");
else
    Console.WriteLine($"YOU LOSE! The number was {maxNumber}. You took {guessCount} tr{(guessCount == 1 ? "y" : "ies")} but you went over");

Console.ReadLine();