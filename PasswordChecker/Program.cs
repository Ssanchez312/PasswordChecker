using PasswordCheckLogic;
using System.Text.RegularExpressions;
Console.WriteLine("=== Password Strength Checker ===\n");

while (true)
{
    Console.Write("Enter a password to check (or 'quit' to exit): ");
    string input = Console.ReadLine();

    if (input?.ToLower() == "quit") break;

    CheckPasswordStrength(input);
    Console.WriteLine();
}

static void CheckPasswordStrength(string password)
{
    if (string.IsNullOrEmpty(password))
    {
        Console.WriteLine("Password cannot be empty.");
        return;
    }

    int score = 0;

    bool hasMinLength = password.Length >= 8;
    bool hasLongLength = password.Length >= 12;
    bool hasUppercase = Regex.IsMatch(password, @"[A-Z]");
    bool hasLowercase = Regex.IsMatch(password, @"[a-z]");
    bool hasDigit = Regex.IsMatch(password, @"\d");
    bool hasSpecialChar = Regex.IsMatch(password, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]");
    bool hasNoSpaces = !password.Contains(" ");

    if (hasMinLength) score++;
    if (hasLongLength) score++;
    if (hasUppercase) score++;
    if (hasLowercase) score++;
    if (hasDigit) score++;
    if (hasSpecialChar) score++;
    if (hasNoSpaces) score++;

    // Display criteria feedback
    Console.WriteLine("\n--- Criteria ---");
    PrintCriteria("At least 8 characters", hasMinLength);
    PrintCriteria("At least 12 characters", hasLongLength);
    PrintCriteria("Uppercase letter (A-Z)", hasUppercase);
    PrintCriteria("Lowercase letter (a-z)", hasLowercase);
    PrintCriteria("Number (0-9)", hasDigit);
    PrintCriteria("Special character", hasSpecialChar);
    PrintCriteria("No spaces", hasNoSpaces);

    // Display strength rating
    string strength;
    ConsoleColor color;

    if (score <= 2) { strength = "Very Weak"; color = ConsoleColor.Red; }
    else if (score <= 3) { strength = "Weak"; color = ConsoleColor.DarkRed; }
    else if (score <= 4) { strength = "Fair"; color = ConsoleColor.Yellow; }
    else if (score <= 5) { strength = "Strong"; color = ConsoleColor.Cyan; }
    else { strength = "Very Strong"; color = ConsoleColor.Green; }

    Console.Write("\nStrength: ");
    Console.ForegroundColor = color;
    Console.WriteLine($"{strength} ({score}/7)");
    Console.ResetColor();
}
   static void PrintCriteria(string label, bool passed)
    {
        Console.ForegroundColor = passed ? ConsoleColor.Green : ConsoleColor.Red;
        Console.Write(passed ? "  [✓] " : "  [✗] ");
        Console.ResetColor();
        Console.WriteLine(label);
    }