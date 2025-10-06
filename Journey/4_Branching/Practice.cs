namespace Branching;

public class Practice
{
  // Praktik 4.1 - [IF] Mengecek angka positif
  public static void _1()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 0)
      Console.WriteLine("The number is positive.");
  }

  // Praktik 4.2 - [IF] Mengecek usia minimal
  public static void _2()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age >= 17)
      Console.WriteLine("You're old enough to make a KTP.");
  }

  // Praktik 4.3 - [IF] Mengecek nilai ujian
  public static void _3()
  {
    Console.Write("Enter your test score: ");
    int score = int.Parse(Console.ReadLine() ?? "0");

    if (score >= 75)
      Console.WriteLine("Congrats, You pass!");
  }

  // Praktik 4.4 - [IF-ELSE] Mengecek bilangan positif atau negatif
  public static void _4()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num >= 0)
      Console.WriteLine("The number is positive.");
    else
      Console.WriteLine("The number is negative.");
  }

  // Praktik 4.5 - [IF-ELSE] Mengecek usia dewasa atau anak-anak
  public static void _5()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age >= 17)
      Console.WriteLine("You're an adult");
    else
      Console.WriteLine("You're still a child");
  }

  // Praktik 4.6 - [IF-ELSE] Mengecek kelulusan berdasarkan nilai
  public static void _6()
  {
    Console.Write("Enter your test score: ");
    int score = int.Parse(Console.ReadLine() ?? "0");

    if (score >= 75)
      Console.WriteLine("Pass!");
    else
      Console.WriteLine("Failed!");
  }

  // Praktik 4.7 - [IF-ELSE-IF] Menentukan kategori nilai
  public static void _7()
  {
    Console.Write("Enter your score: ");
    int score = int.Parse(Console.ReadLine() ?? "0");

    if (score >= 90)
      Console.WriteLine("Predicate: A");
    else if (score >= 75)
      Console.WriteLine("Predicate: B");
    else if (score >= 60)
      Console.WriteLine("Predicate: C");
    else
      Console.WriteLine("Predicate: D");
  }

  // Praktik 4.8 - [IF-ELSE-IF] Menentukan jenis bilangan
  public static void _8()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 0)
      Console.WriteLine("Positive number.");
    else if (num < 0)
      Console.WriteLine("Negative number.");
    else
      Console.WriteLine("Zero point.");
  }

  // Praktik 4.9 - [IF-ELSE-IF] Menentukan biaya tiket berdasarkan umur
  public static void _9()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age < 5)
      Console.WriteLine("Ticket Price: Free");
    else if (age <= 12)
      Console.WriteLine("Ticket Price: Rp20.000");
    else if (age <= 60)
      Console.WriteLine("Ticket Price: Rp50.000");
    else
      Console.WriteLine("Ticket Price: Rp30.000 (Elderly Discount)");
  }

  // Praktik 4.10 - [SWITCH-CASE] Menentukan nama hari
  public static void _10()
  {
    Console.Write("Enter a number (1-7): ");
    int day = int.Parse(Console.ReadLine() ?? "0");

    switch (day)
    {
      case 1: Console.WriteLine("Monday"); break;
      case 2: Console.WriteLine("Tuesday"); break;
      case 3: Console.WriteLine("Wednesday"); break;
      case 4: Console.WriteLine("Thursday"); break;
      case 5: Console.WriteLine("Friday"); break;
      case 6: Console.WriteLine("Saturday"); break;
      case 7: Console.WriteLine("Sunday"); break;
      default: Console.WriteLine("Invalid input!"); break;
    }
  }

  // Praktik 4.11 - [SWITCH-CASE] Menentukan nama bulan
  public static void _11()
  {
    Console.Write("Enter a number (1-12): ");
    int month = int.Parse(Console.ReadLine() ?? "0");

    switch (month)
    {
      case 1: Console.WriteLine("January"); break;
      case 2: Console.WriteLine("February"); break;
      case 3: Console.WriteLine("March"); break;
      case 4: Console.WriteLine("April"); break;
      case 5: Console.WriteLine("May"); break;
      case 6: Console.WriteLine("June"); break;
      case 7: Console.WriteLine("July"); break;
      case 8: Console.WriteLine("August"); break;
      case 9: Console.WriteLine("September"); break;
      case 10: Console.WriteLine("October"); break;
      case 11: Console.WriteLine("November"); break;
      case 12: Console.WriteLine("December"); break;
      default: Console.WriteLine("Invalid input!"); break;
    }
  }

  // Praktik 4.12 - [SWITCH-CASE] Menu sederhana (kasir)
  public static void _12()
  {
    Console.WriteLine(
      """
      Food Menu
      1. Fried Rice
      2. Chicken Noodles
      3. Soto Ayam

      """
    );
    Console.Write("Select menu (1-3): ");
    int selected = int.Parse(Console.ReadLine() ?? "0");

    switch (selected)
    {
      case 1: Console.WriteLine("You selected Fried Rice; Price: Rp15.000"); break;
      case 2: Console.WriteLine("You selected Chicken Noodle; Price: Rp12.000"); break;
      case 3: Console.WriteLine("You selected Soto Ayam; Price: Rp10.000"); break;
      default: Console.WriteLine("That menu isn't available"); break;
    }
  }
}