namespace Arrays;

public class Assigment
{
  // Tugas 6.1 - Buatlah sebuah array untuk menampilkan tiga buah elemen yang berisi :
  //   nama siswa, jenis kelamin dan kelas.
  public static void _1()
  {
    int len = 3;

    string[] name = new string[len];
    char[] gender = new char[len];
    string[] clasz = new string[len];

    for (int i = 0; i < len; i++)
    {
      Console.WriteLine($"Enter student no. {i + 1}");
      Console.Write("Name → ");
      name[i] = Console.ReadLine() ?? string.Empty;
      Console.Write("Gender (L/P) → ");
      gender[i] = char.Parse(Console.ReadLine() ?? string.Empty);
      Console.Write("Class → ");
      clasz[i] = Console.ReadLine() ?? string.Empty;
      Console.WriteLine();
    }

    Console.WriteLine("-- Students Data --");
    for (int i = 0; i < len; i++)
      Console.WriteLine($"Name: {name[i]} | Gender: {gender[i]} | Class: {clasz[i]}");
  }
}