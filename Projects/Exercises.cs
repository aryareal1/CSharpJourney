public class Exercises
{
  // Latihan 1 (3.1) - Buatlah program untuk mengubah / konversi suhu dari Celcius ke fahrenheit dan reamur.
  public static void _1()
  {
    Console.WriteLine("╰┈➤  Latihan 1 - Konversi Suhu");
    Console.Write("Masukkan suhu dalam Celcius: ");
    double cel = double.Parse(Console.ReadLine() ?? "0");

    double fah = (cel * 9 / 5) + 32;
    double rem = cel * 4 / 5;
    double kel = cel + 273.15;

    Console.WriteLine(
      $"""

      ⁕ Hasil Konversi
      Celcius    : {cel} °C
      Fahrenheit : {fah} °F
      Reamur     : {rem} °Re
      Kelvin     : {kel} K
      """
    );
  }

  // Latihan 2 (3.2) - Buatlah program untuk mengkonversi nilai tukar Rupiah ke mata uang lain
  public static void _2()
  {
    Console.WriteLine("╰┈➤  Latihan 2 - Konversi Mata Uang");

    Console.Write("Masukkan jumlah uang dalam rupiah (IDR): ");
    double idr = double.Parse(Console.ReadLine() ?? "0");

    double usd = idr / 16_635;
    double gbp = idr / 22_345.81;
    double jpy = idr / 111.93;
    double sar = idr / 4_435.44;

    Console.WriteLine(
      $"""
      ⁕ Hasil Konversi
      Rupiah (IDR) : Rp{idr:0.00}
      Dollar (USD) : ${usd:0.00}
      Pound (GBP)  : £{gbp:0.00}
      Yen (JPY)    : ¥{jpy:0.00}
      Riyal (SAR)  : ر.س {sar:0.00}
      """
    );
  }
}