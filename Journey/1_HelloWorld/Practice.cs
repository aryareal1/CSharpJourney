namespace HelloWorld;

public class Practice
{
  // Praktik 1.1 - Menuliskan kode pertama kali di editor visual studio.
  public static void _1()
  {
    Console.WriteLine(
          """
      Halo, dunia!
      Nama saya Arya
      Saya belajar bahasa C#
      """
        );
  }

  // Praktik 1.2 - Fungsi Output pada C# menggunakan fungsi WriteLine()
  public static void _2()
  {
    Console.WriteLine(
      """
      Selamat datang di Pemrograman C#
      Ini adalah tutorial belajar C# dari dasar
      Terima kasih sudah menggunakan program ini
      """
    );
  }

  // Praktik 1.3 - Perbedaan WriteLine() dengan Write()
  public static void _3()
  {
    Console.WriteLine("────୨ BIODATA SAYA ৎ────");
    Console.Write("Nama: ");
    Console.Write("Arya");
    Console.WriteLine();
    Console.WriteLine("Alamat: Indonesia");

    Console.WriteLine();

    Console.WriteLine("────୨ BIODATA SAYA ৎ────");
    Console.Write("Nama: ");
    Console.Write("Arya");
    // Console.WriteLine();
    Console.WriteLine("Alamat: Indonesia");

    Console.WriteLine(
      """
      
      ★ Penjelasan: Write itu ngeprint tanpa menambahkan line break (baris baru),
                    sedangkan WriteLine itu ngeprint dan menambahkan line break (baris baru)
                    sehingga output berikutnya akan berada di baris bawahnya.
      """
    );
  }

  // Praktik 1.4 - Fungsi Input pada C#
  public static void _4()
  {
    Console.WriteLine("────୨ PROGRAM INPUT NAMA ৎ────");
    Console.Write("Tuliskan namamu: ");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine($"Hi {name}, welcome to the program!");
  }

  // Praktik 1.5 - Penggunaan input dan output C#
  public static void _5()
  {
    Console.WriteLine("────୨ INPUT BIODATA SISWA ৎ────");
    Console.Write("Nama          : ");
    string name = Console.ReadLine() ?? "";
    Console.Write("Kelas         : ");
    string clas = Console.ReadLine() ?? "";
    Console.Write("Jenis Kelamin : ");
    string gender = Console.ReadLine() ?? "";
    Console.Write("Jurusan       : ");
    string voc = Console.ReadLine() ?? "";

    Console.WriteLine(
      $"""
      
      ───────── ⋆⋅☆⋅⋆ ────────
      ────୨ BIODATA SAYA ৎ────
      Nama          : {name}
      Kelas         : {clas}
      Jenis Kelamin : {gender}
      Jurusan       : {voc}
      ───────── ⋆⋅☆⋅⋆ ────────
      """
    );
  }
}