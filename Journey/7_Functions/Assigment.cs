namespace Functions;

public class Assigment
{
  // Tugas 7.1 - Buat fungsi bernama Kali yang menerima tiga bilangan dan menampilkan hasil perkalian!
  public static void _1()
  {
    static double Kali(double a, double b, double c)
    {
      return a * b * c;
    }

    // Call function and print its result
    var r = Kali(2, 5, 7);
    Console.WriteLine($"Hasil perkalian dari 2 * 5 * 7 adalah {r}");
  }

  // Tugas 7.2 - Buat fungsi RataRata yang menerima tiga nilai dan mengembalikan hasil rata-ratanya!
  public static void _2()
  {
    static double RataRata(double a, double b, double c)
    {
      double total = a + b + c;
      return total / 3;
    }

    // Call function and print its result
    var r = RataRata(80, 83, 92);
    Console.WriteLine($"Rata-rata dari 80, 83, dan 92 adalah {r}");
  }

  // Tugas 7.3 - Buat fungsi KonversiSuhu untuk mengubah suhu dari Celcius ke Fahrenheit dengan rumus:
  //  F = (C × 9/5) + 32.
  public static void _3()
  {
    static double KonversiSuhu(double celcius)
    {
      return (celcius * 9 / 5.0) + 32;
    }

    // Call function and print its result
    var r = KonversiSuhu(32);
    Console.WriteLine($"32℃ jika dikonversikan maka akan menjadi {r}℉");
  }
}