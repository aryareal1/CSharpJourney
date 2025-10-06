namespace Operators;

public class Practice
{
   // Praktik 3.1 - Operator matematika penjumlahan
  public static void _1()
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
  public static void _2()
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
  public static void _3()
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
  public static void _4()
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
  public static void _5()
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
  public static void _6()
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
  public static void _7()
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
  public static void _8()
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
  public static void _9()
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
  public static void _10()
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
}