namespace Operators;

public class Assigment
{
  // Tugas 3.1 - Buat program C# operator matematika : penjumlahan, pengurangan, perkalian, pembagian tiga buah bilangan
  public static void _1()
  {
    Console.WriteLine("╰┈➤  Tugas 3.1 - Operator +-*/ dengan 3 bilangan");

    int InputInt()
    {
      int cursorLeft = Console.CursorLeft;
      try
      {
        return int.Parse(Console.ReadLine() ?? string.Empty);
      }
      catch
      {
        Console.CursorTop--;
        Console.CursorLeft = cursorLeft;
        return InputInt();
      }
    }
    char InputOperator()
    {
      int cursorLeft = Console.CursorLeft;
      try
      {
        char[] operators = { '+', '-', '*', '/' };
        char input = char.Parse(Console.ReadLine() ?? string.Empty);
        if (!operators.Contains(input)) throw new Exception("Wrong operator");
        return input;
      }
      catch
      {
        Console.CursorTop--;
        Console.CursorLeft = cursorLeft;
        return InputOperator();
      }
    }


    Console.Write("Enter the first number (int): ");
    int a = InputInt();
    Console.Write("Enter the first operator (+-*/): ");
    char oA = InputOperator();
    Console.Write("Enter the second number (int): ");
    int b = InputInt();
    Console.Write("Enter the second operator (+-*/): ");
    char oB = InputOperator();
    Console.Write("Enter the third number (int): ");
    int c = InputInt();

    int rA = oA == '+' ? a + b : oA == '-' ? a - b : oA == '*' ? a * b : oA == '/' ? a / b : 0;
    int r = oB == '+' ? rA + c : oB == '-' ? rA - c : oB == '*' ? rA * c : oB == '/' ? rA / c : 0;
    Console.WriteLine($"The result of {a}{oA}{b}{oB}{c} is {r}");
  }

  // Tugas 3.2 - Buat program untuk memasukkan nilai siswa.
  public static void _2()
  {
    Console.WriteLine("╰┈➤  Tugas 3.2 - Nilai Siswa");

    double InputScore()
    {
      double result;
      while (!double.TryParse(Console.ReadLine(), out result)) ;
      return result;
    }

    Console.Write("What's your name? ");
    string name = Console.ReadLine() ?? string.Empty;
    Console.Write("What grade are you now? ");
    string grade = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Input your test score below!");
    Console.Write("Math → ");
    double math = InputScore();
    Console.Write("Indonesian → ");
    double indo = InputScore();
    Console.Write("English → ");
    double eng = InputScore();

    double total = math + indo + eng;
    double average = total / 3;

    Console.WriteLine(
      $"""
      
      Here's the result:
      Student Name     : {name}
      Grade            : {grade}
      ---
      Math Score       : {math}
      Indonesian Score : {indo}
      English Score    : {eng}
      Average Score    : {average}
      Total Score      : {total} / 300 ({total / 300 * 100}%)
      """);
  }
}