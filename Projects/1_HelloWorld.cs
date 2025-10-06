public class HelloWorld
{
  // Praktik 1.1 - Menuliskan kode pertama kali di editor visual studio.
  public static void Practice1()
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
  public static void Practice2()
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
  public static void Practice3()
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
  public static void Practice4()
  {
    Console.WriteLine("────୨ PROGRAM INPUT NAMA ৎ────");
    Console.Write("Tuliskan namamu: ");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine($"Hi {name}, welcome to the program!");
  }

  // Praktik 1.5 - Penggunaan input dan output C#
  public static void Practice5()
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

  // Tugas 1.1 - Buatlah kode program untuk menampilkan biodata kalian masing-masing
  public static void Assigment1()
  {
    Console.WriteLine("────୨ INPUT BIODATA SISWA ৎ────");

    Console.Write("Nama lengkap? ");
    string fullName = Console.ReadLine() ?? "";
    Console.Write("Nama panggilan? ");
    string nickname = Console.ReadLine() ?? "";
    Console.Write("Jenis kelamin (L/P)? ");
    string gender = Console.ReadLine() ?? "";
    Console.Write("Agama? ");
    string religius = Console.ReadLine() ?? "";
    Console.Write("Umur? ");
    string age = Console.ReadLine() ?? "";
    Console.Write("Kelas? ");
    string clas = Console.ReadLine() ?? "";
    Console.Write("Jurusan? ");
    string voc = Console.ReadLine() ?? "";
    Console.Write("Alamat? ");
    string address = Console.ReadLine() ?? "";
    Console.Write("Hobi? ");
    string hobby = Console.ReadLine() ?? "";
    Console.Write("Cita-cita? ");
    string dream = Console.ReadLine() ?? "";

    // Parse gender
    if (gender.ToLower() == "l") gender = "Laki-laki";
    if (gender.ToLower() == "p") gender = "Perempuan";

    Console.WriteLine(
      $"""

      ───────── ⋆⋅☆⋅⋆ ────────
      ────୨ BIODATA SAYA ৎ────
      Nama Lengkap   : {fullName}
      Nama Panggilan : {nickname}
      Jenis Kelamin  : {gender}
      Agama          : {religius}
      Umur           : {age}
      Kelas          : {clas}
      Jurusan        : {voc}
      Alamat         : {address}
      Hobi           : {hobby}
      Cita-cita      : {dream}
      ───────── ⋆⋅☆⋅⋆ ────────
      """
    );
  }
}