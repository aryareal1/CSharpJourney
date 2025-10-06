public class Operators
{
  // Praktik 3.1 - Operator matematika penjumlahan
  public static void Practice1()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.1 - Penjumlahan");

    Console.Write("Enter the first number (int): ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number (int): ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {a + b} \n");

    Console.Write("Enter the third number (double): ");
    double c = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the fourth number (double): ");
    double d = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {c + d}");
  }

  // Praktik 3.2 - Operator matematika pengurangan
  public static void Practice2()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.2 - Pengurangan");

    Console.Write("Enter the first number (int): ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number (int): ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {a - b} \n");

    Console.Write("Enter the third number (double): ");
    double c = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the fourth number (double): ");
    double d = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {c - d}");
  }

  // Praktik 3.3 - Operator matematika perkalian
  public static void Practice3()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.3 - Perkalian");

    Console.Write("Enter the first number (int): ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number (int): ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {a * b} \n");

    Console.Write("Enter the third number (double): ");
    double c = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the fourth number (double): ");
    double d = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {c * d}");
  }

  // Praktik 3.4 - Operator matematika pembagian
  public static void Practice4()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.4 - Pembagian");

    Console.Write("Enter the first number (int): ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number (int): ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {a / b} \n");

    Console.Write("Enter the third number (double): ");
    double c = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the fourth number (double): ");
    double d = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {c / d}");
  }

  // Praktik 3.5 - Operator matematika sisa bagi
  public static void Practice5()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.5 - Modulo (Sisa Bagi)");

    Console.Write("Enter the first number (int): ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number (int): ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {a % b} \n");

    Console.Write("Enter the third number (double): ");
    double c = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the fourth number (double): ");
    double d = double.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The result are {c % d}");
  }

  // Praktik 3.6 - Operator matematika increment (penambahan beruntun)
  public static void Practice6()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.6 - Increments");

    Console.Write("Enter a number: ");
    int x = int.Parse(Console.ReadLine() ?? string.Empty);
    x++;
    Console.WriteLine($"After x++, the number would be {x} \n");

    Console.Write("Enter another number: ");
    int y = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The y are currently {y}. When written as ++y, the number would be {++y} \n");
  }

  // Praktik 3.7 - Operator matimatika decrement (pengurangan beruntun)
  public static void Practice7()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.7 - Decrements");

    Console.Write("Enter a number: ");
    int x = int.Parse(Console.ReadLine() ?? string.Empty);
    x--;
    Console.WriteLine($"After x--, the number would be {x} \n");

    Console.Write("Enter another number: ");
    int y = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine($"The y are currently {y}. When written as --y, the number would be {--y} \n");
  }

  // Praktik 3.8 - Operator perbandingan
  public static void Practice8()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.8 - Comparison Operator");

    Console.Write("Enter the first number: ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number: ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine(
      $"""
      Comparison results:
      {a} == {b} : {a == b}
      {a} != {b} : {a != b}
      {a} >  {b} : {a > b}
      {a} <  {b} : {a < b}
      {a} >= {b} : {a >= b}
      {a} <= {b} : {a <= b}
      """
    );
  }

  // Praktik 3.9 - Operator logika
  public static void Practice9()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.9 - Logical Operators");

    Console.Write("Enter the first number: ");
    int a = int.Parse(Console.ReadLine() ?? string.Empty);
    Console.Write("Enter the second number: ");
    int b = int.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine(
      $"""
      Logic results:
      AND | {a} > 5 && {b} < 10 : {a > 5 && b < 10}
      OR  | {a} > 5 || {b} < 10 : {a > 5 || b < 10}
      NOT | !({a} > {b})        : {!(a > b)}
      """
    );
  }

  // Praktik 3.10 - Operator assigment (penugasan)
  public static void Practice10()
  {
    Console.WriteLine("ׂ╰┈➤  Praktik3.10 - Assigment Operators");

    Console.Write("Enter a number: ");
    int x = int.Parse(Console.ReadLine() ?? string.Empty);

    Console.WriteLine("Assigments result:");
    Console.WriteLine($"Start value is x = {x}");

    x += 5;
    Console.WriteLine($"After x += 5, it assigned to {x}");
    x -= 2;
    Console.WriteLine($"After x -= 2, it assigned to {x}");
    x *= 3;
    Console.WriteLine($"After x *= 3, it assigned to {x}");
    x /= 4;
    Console.WriteLine($"After x /= 4, it assigned to {x}");
    x %= 3;
    Console.WriteLine($"After x %= 3, it assigned to {x}");
  }

  // Tugas 3.1 - Buat program C# operator matematika : penjumlahan, pengurangan, perkalian, pembagian tiga buah bilangan
  public static void Assigment1()
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
  public static void Assigment2()
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