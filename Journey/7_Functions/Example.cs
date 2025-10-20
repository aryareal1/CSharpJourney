namespace Functions;

public class Example
{
  // Contoh 7.1 - Penggunaan fungsi membuat program sederhana
  //   Menghitung Luas Persegi Panjang Menggunakan Fungsi
  public static void _1()
  {
    static double CountArea(double length, double width)
    {
      double area = length * width;
      return area;
    }

    Console.Write("Masukkan panjang (cm): ");
    double length = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Masukkan lebar (cm): ");
    double width = double.Parse(Console.ReadLine() ?? "0");

    double result = CountArea(length, width);
    Console.WriteLine($"Luas persegi panjangnya adalah {result}cm");
  }

  // Contoh 7.2 - Penggunaan fungsi membuat program sederhana Kalkulator
  public static void _2()
  {
    bool shouldLoop;

    do
    {
      Console.Clear();
      Console.WriteLine("--- KALKULATOR SEDERHANA ---");
      ShowMenu();
      Console.Write("Pilih operasi (1-4): ");
      string operation = Console.ReadLine() ?? string.Empty;

      double a, b, result = 0;

      if (InputNumber(out a, out b))
      {
        switch (operation)
        {
          case "1":
            result = Add(a, b);
            Console.WriteLine($"\nHasil dari {a} + {b} adalah {result}");
            break;
          case "2":
            result = Subtract(a, b);
            Console.WriteLine($"\nHasil dari {a} - {b} adalah {result}");
            break;
          case "3":
            result = Muliply(a, b);
            Console.WriteLine($"\nHasil dari {a} * {b} adalah {result}");
            break;
          case "4":
            if (b == 0)
              Console.WriteLine($"Error: Tidak dapat membagi dengan 0.");
            else
            {
              result = Divide(a, b);
              Console.WriteLine($"\nHasil dari {a} / {b} adalah {result}");
            }
            break;
          default:
            Console.WriteLine("Ups! Operasi tidak valid");
            break;
        }
      }

      Console.Write("\nApakah kamu mau menghitung lagi? (Y/n)");
      shouldLoop = Console.ReadLine()?.ToLower() != "n";
    } while (shouldLoop);

    Console.WriteLine(
      """
      
      Terima kasih telah menggunakan kalkulator ini.
      Tekan tombol apa aja untuk keluar
      """
    );
    Console.ReadKey();

    /* --- Util Functions --- */

    static void ShowMenu()
    {
      Console.WriteLine(
        """
        Operasi Matematika
        1. Penjumlahan
        2. Pengurangan
        3. Perkalian
        4. Pembagian
        """
      );
    }

    static bool InputNumber(out double a, out double b)
    {
      Console.Write("Masukkan angka pertama: ");
      if (!double.TryParse(Console.ReadLine(), out a))
      {
        Console.WriteLine("Angka pertama tidak valid!");
        b = 2;
        return false;
      }

      Console.Write("Masukkan angka kedua: ");
      if (!double.TryParse(Console.ReadLine(), out b))
      {
        Console.WriteLine("Angka kedua tidak valid!");
        return false;
      }

      return true;
    }

    static double Add(double a, double b)
    {
      return a + b;
    }
    static double Subtract(double a, double b)
    {
      return a - b;
    }
    static double Muliply(double a, double b)
    {
      return a * b;
    }
    static double Divide(double a, double b)
    {
      return a / b;
    }
  }
}