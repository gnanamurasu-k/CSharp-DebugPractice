using System;

class DebugExample2_VotingEligibility
{
    static void Main()
    {
        Console.WriteLine("=== Debug Example 2: Voting Eligibility Check ===\n");

        // Common mistake:
        // ❌ Console.ReadLine() is string, but using it as int directly.
        // FIX: Must convert using int.Parse() or TryParse().

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Fixed conversion with error handling (TryParse method)
        bool isValid = int.TryParse(input, out int age);

        if (!isValid)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            return;  // stop program if age is invalid
        }

        // Common mistake:
        // ❌ Wrong if-else logic (e.g., doing if(age > 18) instead of >=).
        // FIX: Correct logical conditions

        if (age >= 18)
        {
            Console.WriteLine("Result: You are eligible to vote.");
        }
        else
        {
            // Also correct message formatting with string interpolation
            Console.WriteLine($"Result: You are NOT eligible to vote. You need {18 - age} more years.");
        }

        Console.WriteLine("\n(Program finished correctly – all logic errors fixed.)");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
