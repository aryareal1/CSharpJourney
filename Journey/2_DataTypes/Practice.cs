namespace DataTypes;

public class Practice
{
  // Praktik 2.1 - Variabel bilangan bulat dan teks
  public static void _1()
  {
    int umur = 16;
    string nama = "Budi";

    Console.WriteLine("Nama: " + nama);
    Console.WriteLine("Umur: " + umur);
  }

  // Praktik 2.2 - Variabel desimal dan karakter
  public static void _2()
  {
    double tinggi = 170.5;
    char jenisKelamin = 'L';

    Console.WriteLine("Tinggi badan: " + tinggi + "cm");
    Console.WriteLine("Jenis Kelamin: " + jenisKelamin);
  }

  // Praktik 2.3 - Variabel logika (boolean)
  public static void _3()
  {
    bool isPelajar = true;
    string sekolah = "SMK Negeri 1 Kandeman";

    Console.WriteLine("Apakah masih pelajar? " + isPelajar);
    Console.WriteLine("Sekolah: " + sekolah);
  }

  // Praktik 2.4 - Variabel dengan tipe data yang bervariasi
  public static void _4()
  {
    int age = 17;
    double nilai = 85.5;
    char grade = 'A';
    string name = "Budi";
    bool isLulus = true;

    Console.WriteLine("Nama Siswa  : " + name);
    Console.WriteLine("Umur        : " + age);
    Console.WriteLine("Nilai       : " + nilai);
    Console.WriteLine("Grade       : " + grade);
    Console.WriteLine("Status Lulus: " + isLulus);

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
}