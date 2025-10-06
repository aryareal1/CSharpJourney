public class Branching
{
  // Praktik 4.1 - [IF] Mengecek angka positif
  public static void Practice1()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 0)
      Console.WriteLine("The number is positive.");
  }

  // Praktik 4.2 - [IF] Mengecek usia minimal
  public static void Practice2()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age >= 17)
      Console.WriteLine("You're old enough to make a KTP.");
  }

  // Praktik 4.3 - [IF] Mengecek nilai ujian
  public static void Practice3()
  {
    Console.Write("Enter your test score: ");
    int score = int.Parse(Console.ReadLine() ?? "0");

    if (score >= 75)
      Console.WriteLine("Congrats, You pass!");
  }

  // Praktik 4.4 - [IF-ELSE] Mengecek bilangan positif atau negatif
  public static void Practice4()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num >= 0)
      Console.WriteLine("The number is positive.");
    else
      Console.WriteLine("The number is negative.");
  }

  // Praktik 4.5 - [IF-ELSE] Mengecek usia dewasa atau anak-anak
  public static void Practice5()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age >= 17)
      Console.WriteLine("You're an adult");
    else
      Console.WriteLine("You're still a child");
  }

  // Praktik 4.6 - [IF-ELSE] Mengecek kelulusan berdasarkan nilai
  public static void Practice6()
  {
    Console.Write("Enter your test score: ");
    int score = int.Parse(Console.ReadLine() ?? "0");

    if (score >= 75)
      Console.WriteLine("Pass!");
    else
      Console.WriteLine("Failed!");
  }

  // Praktik 4.7 - [IF-ELSE-IF] Menentukan kategori nilai
  public static void Practice7()
  {
    Console.Write("Enter your score: ");
    int score = int.Parse(Console.ReadLine() ?? "0");

    if (score >= 90)
      Console.WriteLine("Predicate: A");
    else if (score >= 75)
      Console.WriteLine("Predicate: B");
    else if (score >= 60)
      Console.WriteLine("Predicate: C");
    else
      Console.WriteLine("Predicate: D");
  }

  // Praktik 4.8 - [IF-ELSE-IF] Menentukan jenis bilangan
  public static void Practice8()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 0)
      Console.WriteLine("Positive number.");
    else if (num < 0)
      Console.WriteLine("Negative number.");
    else
      Console.WriteLine("Zero point.");
  }

  // Praktik 4.9 - [IF-ELSE-IF] Menentukan biaya tiket berdasarkan umur
  public static void Practice9()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age < 5)
      Console.WriteLine("Ticket Price: Free");
    else if (age <= 12)
      Console.WriteLine("Ticket Price: Rp20.000");
    else if (age <= 60)
      Console.WriteLine("Ticket Price: Rp50.000");
    else
      Console.WriteLine("Ticket Price: Rp30.000 (Elderly Discount)");
  }

  // Praktik 4.10 - [SWITCH-CASE] Menentukan nama hari
  public static void Practice10()
  {
    Console.Write("Enter a number (1-7): ");
    int day = int.Parse(Console.ReadLine() ?? "0");

    switch (day)
    {
      case 1: Console.WriteLine("Monday"); break;
      case 2: Console.WriteLine("Tuesday"); break;
      case 3: Console.WriteLine("Wednesday"); break;
      case 4: Console.WriteLine("Thursday"); break;
      case 5: Console.WriteLine("Friday"); break;
      case 6: Console.WriteLine("Saturday"); break;
      case 7: Console.WriteLine("Sunday"); break;
      default: Console.WriteLine("Invalid input!"); break;
    }
  }

  // Praktik 4.11 - [SWITCH-CASE] Menentukan nama bulan
  public static void Practice11()
  {
    Console.Write("Enter a number (1-12): ");
    int month = int.Parse(Console.ReadLine() ?? "0");

    switch (month)
    {
      case 1: Console.WriteLine("January"); break;
      case 2: Console.WriteLine("February"); break;
      case 3: Console.WriteLine("March"); break;
      case 4: Console.WriteLine("April"); break;
      case 5: Console.WriteLine("May"); break;
      case 6: Console.WriteLine("June"); break;
      case 7: Console.WriteLine("July"); break;
      case 8: Console.WriteLine("August"); break;
      case 9: Console.WriteLine("September"); break;
      case 10: Console.WriteLine("October"); break;
      case 11: Console.WriteLine("November"); break;
      case 12: Console.WriteLine("December"); break;
      default: Console.WriteLine("Invalid input!"); break;
    }
  }

  // Praktik 4.12 - [SWITCH-CASE] Menu sederhana (kasir)
  public static void Practice12()
  {
    Console.WriteLine(
      """
      Food Menu
      1. Fried Rice
      2. Chicken Noodles
      3. Soto Ayam

      """
    );
    Console.Write("Select menu (1-3): ");
    int selected = int.Parse(Console.ReadLine() ?? "0");

    switch (selected)
    {
      case 1: Console.WriteLine("You selected Fried Rice; Price: Rp15.000"); break;
      case 2: Console.WriteLine("You selected Chicken Noodle; Price: Rp12.000"); break;
      case 3: Console.WriteLine("You selected Soto Ayam; Price: Rp10.000"); break;
      default: Console.WriteLine("That menu isn't available"); break;
    }
  }

  // Contoh 4.1 - Program untuk mengetahui karakter yang diinputkan, apakah huruf Besar, huruf kecil, spasi, digit, atau yang lainnya!
  public static void Example1()
  {
    Console.Write("Enter a character: ");
    char x = Console.ReadKey().KeyChar;

    if (char.IsUpper(x))
      Console.WriteLine("The character is uppercased.");
    else if (char.IsLower(x))
      Console.WriteLine("The character is lowercased.");
    else if (char.IsWhiteSpace(x))
      Console.WriteLine("The character is a space.");
    else if (char.IsDigit(x))
      Console.WriteLine("The character is a digit.");
    else
      Console.WriteLine("The character is an other or a symbol.");
  }

  // Contoh 4.2 - Program untuk mempermudah pembayaran di suatu bioskop
  public static void Example2()
  {
    Console.WriteLine(
      """
      Cinema Payments Program

      Movie Genres:
      1. Horror
      2. Romantic
      """
    );
    Console.Write("Select a genre (1-2): ");
    int genre = int.Parse(Console.ReadLine() ?? "0");
    int price;
    string title;

    if (genre == 1)
    {
      Console.WriteLine(
        """
        
        Horror Movies:
        1. Kang Solah from Kang Max x Nenek Gayung    Rp30.000
        2. Death Whisperer 3                          Rp35.000
        3. Rest Area                                  Rp40.000
        """
      );
      Console.Write("Select the movie (1-3): ");
      int movie = int.Parse(Console.ReadLine() ?? "0");

      if (movie == 1)
      {
        title = "Kang Solah from Kang Max x Nenek Gayung";
        price = 30000;
      }
      else if (movie == 2)
      {
        title = "Death Whisperer 3";
        price = 35000;
      }
      else if (movie == 3)
      {
        title = "Rest Area";
        price = 40000;
      }
      else
      {
        Console.WriteLine("Invalid movie!");
        return;
      }
    }
    else if (genre == 2)
    {
      Console.WriteLine(
        """
        
        Romance Movies:
        1. The Architecture of Love   Rp35.000
        2. Sampai Nanti, Hanna!       Rp30.000
        3. Love for Sale              Rp40.000
        """
      );
      Console.Write("Select the movie (1-3): ");
      int movie = int.Parse(Console.ReadLine() ?? "0");

      if (movie == 1)
      {
        title = "The Architecture of Love";
        price = 35000;
      }
      else if (movie == 2)
      {
        title = "Sampai Nanti, Hanna!";
        price = 30000;
      }
      else if (movie == 3)
      {
        title = "Love for Sale";
        price = 40000;
      }
      else
      {
        Console.WriteLine("Invalid movie!");
        return;
      }
    }
    else
    {
      Console.WriteLine("Invalid genre!");
      return;
    }

    // Showing the result
    Console.WriteLine(
      $"""

      Movie Title: {title}
      Ticket Price: Rp{price}

      Thanks for buying a ticket!
      """
    );
  }

  // Tugas 4.1 - [IF] Buat program untuk menentukan apakah sebuah angka lebih besar dari sepuluh atau tidak.
  public static void Assigment1()
  {
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine() ?? "0");

    if (num > 100)
      Console.WriteLine("The number is greater than 100. Yay!");
  }

  // Tugas 4.2 - [IF-ELSE] Buat program yang meminta input umur. Jika umur ≥ 60, tampilkan “Lansia”, selain itu tampilkan “Bukan Lansia”.
  public static void Assigment2()
  {
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine() ?? "0");

    if (age >= 60)
      Console.WriteLine("You're an elder.");
    else
      Console.WriteLine("You're not an elder.");
  }

  // Tugas 4.3 - [SWITCH-CASE] Buat program yang meminta input angka 1–5 dan menampilkan nama warna:
  //   1 = Merah, 2 = Biru, 3 = Hijau, 4 = Kuning, 5 = Hitam.
  public static void Assigment3()
  {
    Console.Write("Enter a number (1-5): ");
    int color = int.Parse(Console.ReadLine() ?? "0");

    switch (color)
    {
      case 1: Console.WriteLine("Red"); break;
      case 2: Console.WriteLine("Blue"); break;
      case 3: Console.WriteLine("Green"); break;
      case 4: Console.WriteLine("Yellow"); break;
      case 5: Console.WriteLine("Black"); break;
      default: Console.WriteLine("Invalid color!"); break;
    }
  }

  // Tugas 4.4 - Buat program dengan input jam (0–23).
  //   • Jika jam 6–11 → “Selamat Pagi”
  //   • Jika jam 12–15 → “Selamat Siang”
  //   • Jika jam 16–18 → “Selamat Sore”
  //   • Jika jam 19–23 atau 0–5 → “Selamat Malam”
  public static void Assigment4()
  {
    Console.Write("Enter an hour (0-23): ");
    int hour = int.Parse(Console.ReadLine() ?? "0");

    if (hour >= 19 && hour < 24 || hour <= 5)
      Console.WriteLine("Good night (malam)!");
    else if (hour >= 16)
      Console.WriteLine("Good afternoon (sore)!");
    else if (hour >= 12)
      Console.WriteLine("Good day (siang)!");
    else if (hour >= 6)
      Console.WriteLine("Good morning (pagi)!");
  }
}