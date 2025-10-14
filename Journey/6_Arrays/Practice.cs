namespace Arrays;

public class Practice
{
  // Praktik 6.1 - Membuat dan menampilkan data array dengan tipe data string
  public static void _1()
  {
    string[] students = new string[5];
    students[0] = "Andi";
    students[1] = "Budi";
    students[2] = "Citra";
    students[3] = "Dewi";
    students[4] = "Eka";

    Console.WriteLine(
      $"""
      Students Name List:
      1. {students[0]}
      2. {students[1]}
      3. {students[2]}
      4. {students[3]}
      5. {students[4]}
      """
    );
  }

  // Praktik 6.2 - Membuat dan menampilkan data array dengan tipe data integer
  public static void _2()
  {
    int[] num = new int[5];

    Console.Write("Enter the 1st number: ");
    num[0] = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter the 2nd number: ");
    num[1] = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter the 3rd number: ");
    num[2] = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter the 4th number: ");
    num[3] = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter the 5th number: ");
    num[4] = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine(
      $"""

      You entered:
      {num[0]}, {num[1]}, {num[2]}, {num[3]}, {num[4]}
      """
    );
  }

  // Praktik 6.3 - Membuat dan menampilkan data array dengan tipe data integer dan string
  public static void _3()
  {
    string[] name = new string[3];
    int[] score = new int[3];

    Console.Write("Enter the 1st student name: ");
    name[0] = Console.ReadLine() ?? string.Empty;
    Console.Write("Enter the 1st score: ");
    score[0] = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter the 2nd student name: ");
    name[1] = Console.ReadLine() ?? string.Empty;
    Console.Write("Enter the 2nd score: ");
    score[1] = int.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter the 3rd student name: ");
    name[2] = Console.ReadLine() ?? string.Empty;
    Console.Write("Enter the 3rd score: ");
    score[2] = int.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine(
      $"""

      Students Data
      Name: {name[0]} | Score: {score[0]}
      Name: {name[1]} | Score: {score[1]}
      Name: {name[2]} | Score: {score[2]}
      """
    );
  }
}