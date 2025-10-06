namespace Branching;

public class Assigment
{
  // Tugas 4.1 - [IF] Buat program untuk menentukan apakah sebuah angka lebih besar dari sepuluh atau tidak.
  public static void _1()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 100)
      Console.WriteLine("The number is greater than 100. Yay!");
  }

  // Tugas 4.2 - [IF-ELSE] Buat program yang meminta input umur. Jika umur ≥ 60, tampilkan “Lansia”, selain itu tampilkan “Bukan Lansia”.
  public static void _2()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age >= 60)
      Console.WriteLine("You're an elder.");
    else
      Console.WriteLine("You're not an elder.");
  }

  // Tugas 4.3 - [SWITCH-CASE] Buat program yang meminta input angka 1–5 dan menampilkan nama warna:
  //   1 = Merah, 2 = Biru, 3 = Hijau, 4 = Kuning, 5 = Hitam.
  public static void _3()
  {
    Console.Write("Enter a number (1-5): ");
    int color = int.Parse(Console.ReadLine() ?? "0");

    switch (color)
    {
      case 1: Console.WriteLine("Red"); break;
      case 2: Console.WriteLine("Blue"); break;
      case 3: Console.WriteLine("Green"); break;
      case 4: Console.WriteLine("Yellow"); break;
      case 5: Console.WriteLine("Black"); break;
      default: Console.WriteLine("Invalid color!"); break;
    }
  }

  // Tugas 4.4 - Buat program dengan input jam (0–23).
  //   • Jika jam 6–11 → “Selamat Pagi”
  //   • Jika jam 12–15 → “Selamat Siang”
  //   • Jika jam 16–18 → “Selamat Sore”
  //   • Jika jam 19–23 atau 0–5 → “Selamat Malam”
  public static void _4()
  {
    Console.Write("Enter an hour (0-23): ");
    int hour = int.Parse(Console.ReadLine() ?? "0");

    if (hour >= 24 || hour < 0)
      Console.WriteLine("Invalid hour!");
    else if (hour >= 19 || hour <= 5)
      Console.WriteLine("Good night (malam)!");
    else if (hour >= 16)
      Console.WriteLine("Good afternoon (sore)!");
    else if (hour >= 12)
      Console.WriteLine("Good day (siang)!");
    else if (hour >= 6)
      Console.WriteLine("Good morning (pagi)!");
  }
}