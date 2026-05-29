using System;

Random rnd = new Random();

mainMenu:
Console.Clear();
Console.WriteLine("==========================");
Console.WriteLine("   FUN CONSOLE APP        ");
Console.WriteLine("==========================");
Console.WriteLine("1. Lucky Number Game");
Console.WriteLine("2. BMI Calculator");
Console.WriteLine("3. Password Checker");
Console.WriteLine("4. Dice Battle");
Console.WriteLine("5. Chiqish");
Console.WriteLine("==========================");
Console.Write("Tanlang (1-5): ");
string tanlov = Console.ReadLine();

if (tanlov == "1") goto luckyNumber;
if (tanlov == "2") goto bmiCalculator;
if (tanlov == "3") goto passwordChecker;
if (tanlov == "4") goto diceBattle;
if (tanlov == "5") goto chiqish;

Console.WriteLine("Xato! 1-5 kiriting.");
Console.ReadLine();
goto mainMenu;

luckyNumber:
Console.Clear();
Console.WriteLine("LUCKY NUMBER GAME");
int secret = rnd.Next(1, 101);
int urinish = 0;
luckyLoop:
Console.Write("Taxminingiz: ");
int taxmin = int.Parse(Console.ReadLine());
urinish = urinish + 1;
if (taxmin < secret)
{
    Console.WriteLine("Kichik!");
    goto luckyLoop;
}
else if (taxmin > secret)
{
    Console.WriteLine("Katta!");
    goto luckyLoop;
}
else
{
    Console.WriteLine("Togri! " + urinish + " urinishda topdingiz!");
}
Console.ReadLine();
goto mainMenu;

bmiCalculator:
Console.Clear();
Console.WriteLine("BMI CALCULATOR");
Console.Write("Boyingiz (sm): ");
double boy = double.Parse(Console.ReadLine());
Console.Write("Vazningiz (kg): ");
double vazn = double.Parse(Console.ReadLine());
double boyM = boy / 100;
double bmi = vazn / (boyM * boyM);
Console.WriteLine("BMI: " + Math.Round(bmi, 1));
if (bmi < 18.5)
    Console.WriteLine("Underweight");
else if (bmi < 25)
    Console.WriteLine("Normal Weight");
else if (bmi < 30)
    Console.WriteLine("Overweight");
else
    Console.WriteLine("Obese");
Console.ReadLine();
goto mainMenu;

passwordChecker:
Console.Clear();
Console.WriteLine("PASSWORD CHECKER");
Console.Write("Parol kiriting: ");
string parol = Console.ReadLine();
bool kattaHarf = false;
bool kichikHarf = false;
bool raqam = false;
bool maxsus = false;
string belgilar = "!@#$%";
int i = 0;
while (i < parol.Length)
{
    char c = parol[i];
    if (char.IsUpper(c)) kattaHarf = true;
    if (char.IsLower(c)) kichikHarf = true;
    if (char.IsDigit(c)) raqam = true;
    if (belgilar.Contains(c.ToString())) maxsus = true;
    i = i + 1;
}
if (parol.Length >= 8 && kattaHarf && kichikHarf && raqam && maxsus)
    Console.WriteLine("Strong Password!");
else
    Console.WriteLine("Weak Password!");
Console.ReadLine();
goto mainMenu;

diceBattle:
Console.Clear();
Console.WriteLine("DICE BATTLE");
Console.WriteLine("Enter bosing...");
Console.ReadLine();
int sizRoll = rnd.Next(1, 7);
int compRoll = rnd.Next(1, 7);
Console.WriteLine("Siz: " + sizRoll);
Console.WriteLine("Computer: " + compRoll);
if (sizRoll > compRoll)
    Console.WriteLine("YOU WIN!");
else if (compRoll > sizRoll)
    Console.WriteLine("Computer yutdi!");
else
    Console.WriteLine("Teng!");
Console.ReadLine();
goto mainMenu;

chiqish:
Console.WriteLine("Xayr!");