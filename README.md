Password Strength Checker
A simple console-based password strength checker written in C#. Built for educational purposes to demonstrate basic password evaluation techniques

What It Does
This program evaluates the strength of a user-provided password by checking it against a set of common security criteria:

- Minimum length of 8 characters
- Extended length of 12+ characters
- Presence of uppercase letters (A–Z)
- Presence of lowercase letters (a–z)
- Presence of digits (0–9)
- Presence of special characters (e.g. !@#$%^&*)
- Absence of spaces

Each criterion is worth one point, and the total score maps to a strength rating:
Very Weak, Weak, Fair, Strong, or Very Strong. Results are colour-coded in the console for quick readability. The program loops continuously so you can test multiple passwords in one session.

How to Run
Prerequisites:
- .NET SDK 6.0 or later installed on your machine.

Steps:
1. Clone or download this repository.
2. Open a terminal and navigate to the project folder.
3. Create a new console project (if starting fresh)
4. Replace the contents of Program.cs with the provided source code.
5. Run the program

Limitations & Warnings
This program is for educational use only and should not be used to make real password security decisions

Please be aware that:
1. Scoring is simplified: The scoring system does not reflect the true entropy or crackability of a password. A password can be very strong but be easily guessable
2. No attack detection: This tool does not check if a password appears in known breach databases.
3. Passwords are visible in console: Input is not masked, so anyone seeing your screen can see the password being typed in
4. No storage or hashing: Passwords are not being saved, but are processed in plaintext memory, dont use real passwords in untrusted machines or environments.

Ethical Considerations & Responsible Use
Please consider:
- Users who receive a "Very Strong" rating may believe their password is truly secure, when in reality the checker cannot account for dictionary patterns,
credential stuffing lists, or contextual guessing. Relying on this tool to validate real passwords could lead to weaker security practices.
- This tool could be repurposed into a password cracking tool or adapted to optimise password generation for bypassing naive strength checkers on other platforms.
Anyone distributing or modifying this code should be mindful.
- Use this program to learn about what makes passwords stronger, not to validate passwords you actually intend to use for accounts.
- If you adapt or extend this tool, consider adding input masking, entropy-based scoring, and integration with breach-checking APIs to reduce the risk of misleading users.
