namespace HelloWorld;

public class Assigment
{
  // Tugas 1.1 - Buatlah kode program untuk menampilkan biodata kalian masing-masing
  public static void _1()
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