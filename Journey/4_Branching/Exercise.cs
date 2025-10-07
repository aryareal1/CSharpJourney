namespace Branching;

public class Exercise
{
  // Latihan 4.1 - Buatlah program untuk mencari luas menggunakan percabangan switch case untuk menghitung:
  //   • Luas persegi panjang, segitiga, dan lingkaran
  //   • Keliling persegi panjang dan lingkaran
  //   • Luas permukaan kubus dan balok
  //   • Volume kubus dan balok
  public static void _1()
  {
    Console.WriteLine(
      """
      ─── ⋆⋅ PROGRAM MENGHITUNG LUAS & KELILING ⋅⋆ ──
      
      Select Menu:
      1. Luas Persegi Panjang
      2. Luas Segitiga
      3. Luas Lingkaran
      4. Keliling Persegi Panjang
      5. Keliling Lingkaran
      6. Luas Permukaan Kubus
      7. Luas Permukaan Balok
      8. Volume Kubus
      9. Volume Balok
      """
    );
    Console.Write("Choose a menu (1-5): ");
    int menu = int.Parse(Console.ReadLine() ?? "0");

    switch (menu)
    {
      case 1:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Luas Persegi Panjang");
          Console.Write("Enter the length (cm): ");
          double length = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the width (cm): ");
          double width = double.Parse(Console.ReadLine() ?? "0");

          double area = length * width;
          Console.WriteLine($"\n★ The area of that rectangle is {area}cm².");

          break;
        }
      case 2:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Luas Segitiga");
          Console.Write("Enter the base length (cm): ");
          double baseLength = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the height (cm): ");
          double height = double.Parse(Console.ReadLine() ?? "0");

          double area = 1.0 / 2 * baseLength * height;
          Console.WriteLine($"\n★ The area of that triangle is {area}cm².");

          break;
        }
      case 3:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Luas Lingkaran");
          Console.Write("Enter the radius (cm): ");
          double radius = double.Parse(Console.ReadLine() ?? "0");
          double pi = radius % 7 == 0 ? 22 / 7.0 : 3.14;

          double area = pi * Math.Pow(radius, 2);
          Console.WriteLine($"\n★ The area of that circle is {area}cm².");

          break;
        }
      case 4:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Keliling Persegi Panjang");
          Console.Write("Enter the length (cm): ");
          double length = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the width (cm): ");
          double width = double.Parse(Console.ReadLine() ?? "0");

          double perim = 2.0 * (length + width);
          Console.WriteLine($"\n★ The perimeter of that rectangle is {perim}cm.");

          break;
        }
      case 5:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Keliling Lingkaran");
          Console.Write("Enter the radius (cm): ");
          double radius = double.Parse(Console.ReadLine() ?? "0");
          double pi = radius % 7 == 0 ? 22 / 7.0 : 3.14;

          double circum = 2.0 * pi * radius;
          Console.WriteLine($"\n★ The circumference of that circle is {circum}cm.");

          break;
        }
      case 6:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Luas Permukaan Kubus");
          Console.Write("Enter the length of the side (cm): ");
          double sideLength = double.Parse(Console.ReadLine() ?? "0");

          double surfaceArea = 6 * Math.Pow(sideLength, 2);
          Console.WriteLine($"\n★ The surface area of that cube is {surfaceArea}cm².");

          break;
        }
      case 7:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Luas Permukaan Balok");
          Console.Write("Enter the length (cm): ");
          double length = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the width (cm): ");
          double width = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the height (cm): ");
          double height = double.Parse(Console.ReadLine() ?? "0");

          double surfaceArea = 2 * ((length * width) + (length * height) + (width * height));
          Console.WriteLine($"\n★ The surface area of that cuboid is {surfaceArea}cm².");

          break;
        }
      case 8:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Volume Kubus");
          Console.Write("Enter the length of the side (cm): ");
          double sideLength = double.Parse(Console.ReadLine() ?? "0");

          double volume = Math.Pow(sideLength, 3);
          Console.WriteLine($"\n★ The volume of that cube is {volume}cm³.");

          break;
        }
      case 9:
        {
          Console.WriteLine($"ׂ\n╰┈➤  Volume Balok");
          Console.Write("Enter the length (cm): ");
          double length = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the width (cm): ");
          double width = double.Parse(Console.ReadLine() ?? "0");
          Console.Write("Enter the height (cm): ");
          double height = double.Parse(Console.ReadLine() ?? "0");

          double volume = length * width * height;
          Console.WriteLine($"\n★ The volume of that cuboid is {volume}cm³.");

          break;
        }
      default:
        Console.WriteLine("Not a valid menu!");
        break;
    }
  }

  // Latihan 4.2 - Buatlah program C# untuk menghitung Indeks Massa Tubuh (IMT/BMI) menggunakan percabangan
  //   (if–else) agar bisa menentukan kategori berat badan seperti kurus, normal, gemuk, atau obesitas.
  public static void _2()
  {
    Console.WriteLine(" ─── ⋆⋅ PROGRAM MENGHITUNG INDEKS MASA TUBUH (IMT) ⋅⋆ ── \n");

    Console.Write("Enter your weight (kg): ");
    double weight = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Enter your height (m): ");
    double height = double.Parse(Console.ReadLine() ?? "0");

    double imt = weight / Math.Pow(height, 2);
    string desc;

    if (imt < 18.5) desc = "Kurus";
    else if (imt < 25) desc = "Normal";
    else if (imt <= 30) desc = "Kelebihan Berat Badan";
    else desc = "Obesitas";

    Console.WriteLine(
      $"""

      Your IMT is {imt}
      Category: {desc}
      """
    );
  }

  // Latihan 4.3 - Buatlah program untuk menentukan nilai siswa dengan ketentuan
  public static void _3()
  {
    Console.WriteLine(" ─── ⋆⋅ PROGRAM MENGHITUNG NILAI SISWA ⋅⋆ ── \n");

    Console.Write("What's the name? ");
    string name = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Enter the test score!");
    Console.Write("Math → ");
    double math = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Indonesian → ");
    double indo = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("English → ");
    double eng = double.Parse(Console.ReadLine() ?? "0");

    double total = math + indo + eng;
    double average = total / 3.0;

    string grade;
    if (average >= 85) grade = "A";
    else if (average >= 75) grade = "B";
    else if (average >= 65) grade = "C";
    else if (average >= 55) grade = "D";
    else grade = "E";

    bool isLulus = false;
    if (average >= 75) isLulus = true;

    Console.WriteLine(
      $"""

      ★ Assesment Result
      Student Name     : {name}
      Math Score       : {math}
      Indonesian Score : {indo}
      English Score    : {eng}
      ---
      Total Score : {total}
      Average     : {average}
      Grade       : {grade}
      Status      : {(isLulus ? "PASS" : "FAILED")}
      """
    );
  }
}