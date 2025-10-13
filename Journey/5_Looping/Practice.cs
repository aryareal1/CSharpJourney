namespace Looping;

public class Practice
{
  // Praktik 5.1 - [FOR] Perulangan untuk menampilkan angka 1 sampai 10
  public static void _1()
  {
    Console.WriteLine("Looping number from 1 to 10");

    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine($"Number {i}");
    }
    Console.WriteLine("\nLoop finished!");
  }

  // Praktik 5.2 - [FOR] Menghitung Jumlah Angka (Penjumlahan)
  public static void _2()
  {
    Console.WriteLine("Sum number from 1 to 10");
    int sum = 0;
    for (int i = 1; i <= 5; i++)
    {
      sum += i;
      Console.WriteLine($"Added {i}, current total: {sum}");
    }
    Console.WriteLine($"\nLoop finished! Final total: {sum}");
  }

  // Praktik 5.3 - [WHILE] Program terus meminta input dari pengguna sampai pengguna mengetikkan kata "keluar"

  public static void _3()
  {
    string userInput = string.Empty;
    Console.WriteLine("Program will run forever until you type 'exit'");

    while (userInput.ToLower() != "exit")
    {
      Console.Write("Type something ('exit' to stop): ");
      userInput = Console.ReadLine() ?? string.Empty;
      Console.WriteLine($"You typed '{userInput}'");
    }
    Console.WriteLine("\nProgram stopped. Thanks!");
  }

  // Praktik 5.4 - [WHILE] Menghitung mundur dari 5 sampai 1 dan mencetak setiap angka, lalu mencetak pesan di akhir
  public static void _4()
  {
    int count = 5;
    Console.WriteLine("Starting countdown..");
    while (count > 0)
    {
      Console.WriteLine($"Count: {count}");
      count -= 1;
    }
    Console.WriteLine("Finished!");
  }

  // Praktik 5.5 - [DO-WHILE] Menampilkan angka dari 1 sampai dengan 20
  public static void _5()
  {
    int i = 1;
    Console.WriteLine("Counting number from 1 to 20");

    do
    {
      Console.WriteLine(i);
      i++;
    } while (i <= 20);

    Console.WriteLine("Finished!");
  }

  // Praktik 5.6 - [DO-WHILE] Aplikasi ini akan meminta pengguna memasukkan angka genap.
  //   Perulangan akan terus berjalan jika inputnya ganjil.
  public static void _6()
  {
    int num;

    do
    {
      Console.Write("Enter an even number: ");
      if (!int.TryParse(Console.ReadLine(), out num))
      {
        Console.WriteLine("Invalid input! Please type an integer");
        num = 1;
        continue;
      }
      if (num % 2 != 0)
        Console.WriteLine($"The number {num} is odd. Try again!");
    } while (num % 2 != 0);
    Console.WriteLine($"Congrats! You typed an even number: {num}");
  }

  // Praktik 5.7 - [DO-WHILE] - Aplikasi ini menampilkan menu pilihan dan meminta input
  //   hingga pengguna memilih opsi "Keluar" (nomor 3).
  public static void _7()
  {
    int menu;
    Console.WriteLine(
      """
      App Menu
      1. View Data
      2. Add Data
      3. Quit
      """
    );

    do
    {
      Console.Write("Select a menu (1-3): ");

      if (!int.TryParse(Console.ReadLine(), out menu))
      {
        Console.WriteLine("Invalid type! Please enter number 1 to 3");
        continue;
      }

      switch (menu)
      {
        case 1:
          Console.WriteLine("You opened: View Data");
          break;
        case 2:
          Console.WriteLine("You opened: Add Data");
          break;
        case 3:
          Console.WriteLine("Program will end...");
          break;
        default:
          Console.WriteLine("Not a valid menu!");
          break;
      }
    } while (menu != 3);
    Console.WriteLine("Thanks for using the app!");
  }

  // Praktik 5.8 - Program akan meminta nama pengguna dan kemudian bertanya apakah akan mengulang.
  public static void _8()
  {
    bool shouldLoop;

    do
    {
      Console.Write("Enter your name: ");
      string name = Console.ReadLine() ?? string.Empty;
      Console.WriteLine($"Hello, {name}!");

      Console.Write("\nDo you want to repeat it (Y/n): ");
      shouldLoop = Console.ReadLine()?.ToLower() != "n";
    } while (shouldLoop);
    Console.WriteLine("Program closed!");
  }
}