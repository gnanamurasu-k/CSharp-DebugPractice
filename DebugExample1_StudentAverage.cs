using System;

class DebugExample1_StudentAverage
{
    static void Main()
    {
        Console.WriteLine("=== Debug Example 1: Student Average Calculator ===\n");

        // Common beginner mistake:
        // ❌ Not reading input properly or not converting string to int/double.
        // FIX: Use int.Parse or double.Parse safely.

        Console.Write("Enter the number of subjects: ");
        string input = Console.ReadLine();

        // Common mistake:
        // ❌ Forgetting to convert input to integer and directly using string.
        // FIX: Convert to int using int.Parse (or int.TryParse).
        int subjectCount = int.Parse(input);

        // Common mistake:
        // ❌ Using wrong array size or negative value.
        // FIX: Use subjectCount as the array size.
        int[] marks = new int[subjectCount];

        int total = 0;

        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write($"Enter marks for subject {i + 1}: ");

            // Common mistake:
            // ❌ Typo in variable name or reading inside wrong variable.
            // FIX: Always read into a temp string then parse.
            string markInput = Console.ReadLine();
            int mark = int.Parse(markInput);

            // Common mistake:
            // ❌ Using >= 100 or > 100 without checking range.
            // Here we assume marks are valid (0–100).

            marks[i] = mark;
            total += mark;
        }

        // Common mistake:
        // ❌ Integer division when expecting decimal.
        // FIX: Cast to double before division.
        double average = (double)total / subjectCount;

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Total Marks   : " + total);
        Console.WriteLine("Average Marks : " + average);

        // Grade calculation – also corrected logic.
        string grade;
        if (average >= 90)
            grade = "A+";
        else if (average >= 80)
            grade = "A";
        else if (average >= 70)
            grade = "B";
        else if (average >= 60)
            grade = "C";
        else
            grade = "F";

        Console.WriteLine("Grade         : " + grade);

        Console.WriteLine("\n(Program finished without errors – all common issues fixed.)");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
