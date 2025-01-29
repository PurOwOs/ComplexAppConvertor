using System;
using System.Data.SqlTypes;
class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Complex Number Calculator" +
                          "\nBy: Zdeněk Dudek" +
                          "\nDiscord: purowo" +
                          "\nTelegram: username:@PurOwO link:https://t.me/PurOwO");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        double x = 0, y = 0, abs, radians, degrees;
        Console.WriteLine("tvar z = (x+jy)" +
                          "\nVýstupní tvar = Goniometrický");

        Console.Write("x=");
        x = double.Parse(Console.ReadLine());
        Console.Write("y=");
        y = double.Parse(Console.ReadLine());

        abs = Math.Sqrt(x * x + y * y);

        radians = Math.Atan2(y, x);

        degrees = radians * (180 / Math.PI);

        if (degrees < 0)
        {
            degrees += 360;
        }
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Goniometrický Tvar komplexního čísla je:" +
                          $"\nz = {abs:F2} (cos {degrees:F5}° + j sin {degrees:F5}°)");
        Console.WriteLine();
        Console.WriteLine("Děkuji za použití. Stiskněte klávesu po ukončení");
        Console.ReadKey();
        Console.ResetColor();
    }

}