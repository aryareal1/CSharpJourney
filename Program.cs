using System.Reflection;
using Sharprompt;

internal class Program
{
  static void Main()
  {
    // Get all public static methods from classes in assembly
    var praktikMethods = Assembly.GetExecutingAssembly()
      .GetTypes()
      .SelectMany(t => t.GetMethods(BindingFlags.Public | BindingFlags.Static)
        .Where(m => m.Name.StartsWith("Practice") | m.Name.StartsWith("Assigment") | m.Name.StartsWith("Example") | m.Name.StartsWith("_")))
      .ToList();

    // Make list of options like "HelloWorld.Praktik1"
    var options = praktikMethods
      .Select(m => $"{m.DeclaringType?.Name}.{m.Name}")
      .ToList();

    // Show prompt
    var project = Prompt.Select("Choose which project to run", options);

    Console.WriteLine();

    // Separate class name and method
    var parts = project.Split('.');
    var className = parts[0];
    var methodName = parts[1];

    // Find the method
    var method = praktikMethods
      .FirstOrDefault(m =>
        m.DeclaringType?.Name == className &&
        m.Name == methodName);

    // Run the method
    method?.Invoke(null, null);
  }
}