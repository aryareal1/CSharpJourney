namespace Branching;

public class Example
{
  // Contoh 4.1 - Program untuk mengetahui karakter yang diinputkan, apakah huruf Besar, huruf kecil, spasi, digit, atau yang lainnya!
  public static void _1()
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
  public static void _2()
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
}