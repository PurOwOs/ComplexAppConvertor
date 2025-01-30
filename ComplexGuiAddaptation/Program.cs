using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ComplexGuiAddaptation  // Ensure this matches the project namespace
{
    public class Program
    {
        public static MauiApp CreateMauiApp() =>
            MauiApp.CreateBuilder()
                   .UseMauiApp<App>()  // This should refer to App.xaml.cs
                   .Build();
    }
}
