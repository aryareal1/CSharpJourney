namespace Looping;

public class Assigment
{
  // Tugas 5.1 - Buat program menggunakan for untuk menampilkan perkalian 5 (tabel 5).
  public static void _1()
  {
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine($"5 × {i} = {5 * i}");
    }
  }
  
  // Tugas 5.2 - Buat program menggunakan while untuk menampilkan jumlah total dari bilangan 1 sampai 5.
  public static void _2()
  {
    int sum = 0;
    int i = 1;

    while (i <= 5)
    {
      sum += i;
      i++;
    }
    Console.WriteLine($"Total: {sum}");
  }
}