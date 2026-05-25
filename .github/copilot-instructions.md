if (bestScore == 0 || attempts < bestScore)
    {
        bestScore = attempts;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  🏆 YANGI REKORD! Best Score: " + bestScore);
    }
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("\n  ↩️  Menyuga qaytish uchun Enter bosing...");
Console.ResetColor();
Console.ReadLine();
goto mainMenu;

// ════════════════════════════════════════════════════════════
// 💪 2. BMI CALCULATOR
// ════════════════════════════════════════════════════════════
bmiCalculator:
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("  ╔══════════════════════════════════╗");
Console.WriteLine("  ║      💪 BMI CALCULATOR           ║");
Console.WriteLine("  ╚══════════════════════════════════╝\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.Write("  📏 Boyingizni kiriting (sm): ");
Console.ResetColor();
string heightStr = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.White;
Console.Write("  ⚖️  Vazningizni kiriting (kg): ");
Console.ResetColor();
string weightStr = Console.ReadLine();

double height = 0;
double weight = 0;
bool hOk = double.TryParse(heightStr, out height);
bool wOk = double.TryParse(weightStr, out weight);

if (!hOk  !wOk  height <= 0 || weight <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n  ❌ Noto'g'ri qiymat kiritildi!");
    Console.ResetColor();
    System.Threading.Thread.Sleep(1500);
    goto mainMenu;
}

double heightM = height / 100.0;
double bmi = weight / (heightM * heightM);
double bmiRounded = Math.Round(bmi, 1);

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n  ─────────────────────────────────");
Console.WriteLine("  📊 Your BMI: " + bmiRounded);
Console.WriteLine("  ─────────────────────────────────");
Console.ResetColor();

if (bmi < 18.5)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("  ⚠️  Underweight — Ko'proq yeng!");
}
else if (bmi < 25.0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  ✅ Normal Weight — Zo'r! 🎉");
}
else if (bmi < 30.0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("  ⚠️  Overweight — Sport qiling!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("  ❌ Obese — Shifokorga boring!");
}
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("\n  ↩️  Menyuga qaytish uchun Enter bosing...");
Console.ResetColor();
Console.ReadLine();
goto mainMenu;

// ════════════════════════════════════════════════════════════
// 🔐 3. SECRET PASSWORD CHECKER
// ════════════════════════════════════════════════════════════
passwordChecker:
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("  ╔══════════════════════════════════╗");
Console.WriteLine("  ║     🔐 SECRET PASSWORD CHECKER   ║");
Console.WriteLine("  ╚══════════════════════════════════╝\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("  Parol talablari:");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("  • Kamida 8 ta belgi");
Console.WriteLine("  • Katta harf (A-Z)");
Console.WriteLine("  • Kichik harf (a-z)");
Console.WriteLine("  • Raqam (0-9)");
Console.WriteLine("  • Maxsus belgi (!@#$%^&*)");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("\n  🔑 Parolni kiriting: ");
Console.ResetColor();
string password = Console.ReadLine();

bool hasUpper = false;
bool hasLower = false;
bool hasDigit = false;
bool hasSpecial = false;
string specials = "!@#$%^&*()_+-=[]{}|;:,.<>?";

int pi = 0;
while (pi < password.Length)
{
    char c = password[pi];
    if (char.IsUpper(c)) hasUpper = true;
    if (char.IsLower(c)) hasLower = true;
    if (char.IsDigit(c)) hasDigit = true;
    if (specials.Contains(c.ToString())) hasSpecial = true;
    pi = pi + 1;
}