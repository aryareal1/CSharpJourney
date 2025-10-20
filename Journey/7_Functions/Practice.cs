namespace Functions;

public class Practice
{
  // Praktik 7.1 - Fungsi tanpa parameter dan tanpa nilai kembali
  public static void _1()
  {
    static void Greet()
    {
      Console.WriteLine(
        """
        Halo, selamat datang di pembelajaran C#!
        Mari belajar tentang fungsi!
        """
      );
    }

    Greet();
  }

  // Praktik 7.2 - Fungsi dengan parameter
  public static void _2()
  {
    static void GreetName(string name)
    {
      Console.WriteLine(
        $"""
        Halo, {name}!
        Semangat belajar C# hari ini!
        """
      );
    }

    Console.Write("Masukkan namamu: ");
    string studentName = Console.ReadLine() ?? string.Empty;
    GreetName(studentName);
  }

  // Praktik 7.3 - Fungsi dengan nilai kembali
  public static void _3()
  {
    static int Add(int a, int b)
    {
      return a + b;
    }

    Console.Write("Masukkan angka pertama: ");
    int a = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Masukkan angka pertama: ");
    int b = int.Parse(Console.ReadLine() ?? "0");
    int result = Add(a, b);
    Console.WriteLine($"Hasil penjumlahannya adalah {result}");
  }
}