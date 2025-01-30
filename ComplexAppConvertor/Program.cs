using System;

class Program
{
    static void Main()
    {
        // Credits
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Complex Number Calculator" +
                          "\nBy: Zdeněk Dudek" +
                          "\nDiscord: purowo" +
                          "\nTelegram: username:@PurOwO link:https://t.me/PurOwO\n");
        Console.ResetColor();

        // Variable declarations
        double x, y, abs, radians, degrees;

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Format: z = (x + jy)");
        Console.WriteLine("Output: Goniometric Form\n");
        Console.ResetColor();

        // Input validation
        x = GetValidDouble("x=");
        y = GetValidDouble("y=");

        // Math calculations
        abs = Math.Sqrt(x * x + y * y);
        radians = Math.Atan2(y, x);
        degrees = radians * (180 / Math.PI);
        if (degrees < 0) degrees += 360;

        // Output result
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"\nGoniometric form of the complex number:");
        Console.WriteLine($"z = {abs:F2} (cos {degrees:F5}° + j sin {degrees:F5}°)");
        Console.ResetColor();

        Console.WriteLine("\nThank you for using this program. Press any key to exit.");
        Console.ReadKey();
    }

    static double GetValidDouble(string prompt)
    {
        double value;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input! Please enter a valid number.");
            Console.ResetColor();
            Console.Write(prompt);
        }
        return value;
    }
}
