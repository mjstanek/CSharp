// Completed in concurrence with the Microsoft Learn Course
// Add decision logic to your code using `if`, `else`, and `else if` statements in C#
// While completing the freeCodeCamp certification

/*
 * This program is a simple console game involving three dice.
 * The user will roll all three dice and the dice will be totaled
 * up. If any two dice match, the user will gain two bonus points.
 * If all three dice match, the user will gain six bonus points.
 * The user wins if their total score is 15 points or higher.
 */

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int bonusPoints = 0;
string bonusMessage = "";

if ((roll1 == roll2) && (roll1 == roll3))
{
    bonusPoints += 6;
    bonusMessage = "triples";
}
else if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    bonusPoints += 2;
    bonusMessage = "doubles";
}

int totalScore = roll1 + roll2 + roll3 + bonusPoints;

if (bonusPoints != 0)
{
    Console.WriteLine($"You rolled {roll1} and {roll2} and {roll3} and had a " +
        $"bonus of {bonusPoints} points for rolling {bonusMessage} for a " +
        $"grand total of {totalScore} points");
}
else
{
    Console.WriteLine($"You rolled {roll1} and {roll2} and {roll3} for {totalScore} total points");
}

if (totalScore >= 16)
{
    Console.WriteLine("Congratulations! You won a 2003 Mazda Miata!");
}
else if (totalScore >= 10)
{
    Console.WriteLine("Congratulations! You won a new MacBook Air!");
}
else if (totalScore == 7)
{
    Console.WriteLine("Ohhhhh! You won a trip for two to sunny ARUBA!");
}
else
{
    Console.WriteLine("Sorry, you lose. You have to take a kitten home instead.");
}

Console.WriteLine("\n========== Challenge ==========");

/* Goal of this challenge is to display a renewal message whenever a user logs
 * into their software system and is notified that their subscription will end soon.
 * Rules:
 * 1. Your code should only display one message
 * 2. If the user's subscription ends in 10 days or less, display this message:
 * "Your subscription will expire soon. Renew now!"
 * 3. If the user's subscription will end in 5 days or less, display the following:
 * "Your subscription expires in _ days.
    Renew now and save 10%!"
 * 4. If the user's subscription will expire in one day, display the following:
 * "Your subscription expires within a day!
    Renew now and save 20%!"
 * 5. If the user's subscription has ended, display this message:
 * "Your subscription has expired."
 * 6. If the user's subscription will expire in more than 10 days, do nothing.
 */

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration > 10)
{
    return;
}
else
{
    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\r\n" +
            $"Renew now and save {discountPercentage}%!");
    }
    else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days." +
            $"\r\nRenew now and save {discountPercentage}%");
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}