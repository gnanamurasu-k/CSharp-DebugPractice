using System;

class DebugExample3_TopScores
{
    static void Main()
    {
        Console.WriteLine("=== Debug Example 3: Top Scores with Arrays & Loops ===\n");

        // Common mistake:
        // ❌ Using wrong array size or loop range (i <= length instead of i < length)
        // ❌ Confusion between index and count

        Console.Write("Enter how many students: ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out int studentCount);

        if (!isValid || studentCount <= 0)
        {
            Console.WriteLine("Error: Please enter a valid positive number.");
            return;
        }

        int[] scores = new int[studentCount];

        // Get scores
        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"Enter score for student {i + 1}: ");
            string scoreInput = Console.ReadLine();

            bool validScore = int.TryParse(scoreInput, out int score);

            if (!validScore)
            {
                Console.WriteLine("Invalid score entered. Setting score to 0 by default.");
                score = 0;
            }

            // Common mistake:
            // ❌ Using scores[i + 1] here (which causes index error)
            // FIX: Always use scores[i] because i already represents the correct index.
            scores[i] = score;
        }

        // Find highest score
        // Common mistake:
        // ❌ Starting from scores[1] or wrong initial value.
        // FIX: Start with scores[0] as current max.
        int highestScore = scores[0];
        int highestIndex = 0;

        for (int i = 1; i < studentCount; i++)
        {
            if (scores[i] > highestScore)
            {
                highestScore = scores[i];
                highestIndex = i;
            }
        }

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine("Scores entered: ");

        // Print all scores safely
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Student {i + 1}: {scores[i]}");
        }

        Console.WriteLine($"\nHighest score is {highestScore}, by student {highestIndex + 1}.");

        Console.WriteLine("\n(Program finished: common array & loop errors are fixed.)");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
